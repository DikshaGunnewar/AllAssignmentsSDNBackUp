using CountryStateNew.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CountryStateNew.Controllers
{
    public class HomeController : Controller
    {
        EmployeeContext12 context;
        public HomeController()
        {
             context = new EmployeeContext12();
        }
        
        // GET: Home
        public ActionResult Index()
        {
            var emp = context.EmpList.ToList();
            return View(emp);
        }

        #region--Create Employees--
        public ActionResult Create()
        {

            EmployeeContext12 context = new EmployeeContext12();
            ViewBag.CountryList = context.CountryList;
            var model = new Employee12();
            return View(model);
        }


        [HttpPost]
        public ActionResult Create(Employee12 model)
        {
            EmployeeContext12 context = new EmployeeContext12 ();

            if (ModelState.IsValid)
            {
                context.EmpList.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            ViewBag.CountryList = context.CountryList;
            return View(model);
        }

        #endregion

        #region--GetStates--
        public ActionResult GetState(int country)
        {
            EmployeeContext12 context = new EmployeeContext12();

            var states = context.StateList.Where(c => c.CountryId == country);
            return Json(states, JsonRequestBehavior.AllowGet);
        }

        #endregion


        #region--Show Details--
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee12 stud = context.EmpList.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }
        #endregion

        /*  #region--EditEmployee--
          [HttpGet]
          public ActionResult Edit(int? id)
          {
              if (id == null)
              {
                  return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
              }
              Employee12 stud1 = context.EmpList.Find(id);
              if (stud1 == null)
              {
                  return HttpNotFound();
              }
              return View(stud1);
          }

          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Edit([Bind(Include = "EmployeeName,Email,Birthdate,Country,State,Address")] Employee12 stud)
          {
              if (ModelState.IsValid)
              {
                  context.Entry(stud).State = EntityState.Modified;
                  context.SaveChanges();
                  return RedirectToAction("Index");
              }
              return View(stud);
          }
          #endregion        */


        #region--Delete Employee--
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee12 stud1 = context.EmpList.Find(id);
            if (stud1 == null)
            {
                return HttpNotFound();
            }
            return View(stud1);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(int? id, Employee12 stud1)
        {

            try
            {
                Employee12 emp = new Employee12();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

                    stud1 = context.EmpList.Find(id);
                    if (stud1 == null)
                        return HttpNotFound();
                    context.EmpList.Remove(stud1);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(stud1);

            }
            catch
            {
                return View();
            }
        }
        #endregion
    }
}