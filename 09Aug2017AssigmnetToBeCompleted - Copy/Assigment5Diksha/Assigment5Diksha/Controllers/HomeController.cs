using Assigment5Diksha.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Assigment5Diksha.Controllers
{
    public class HomeController : Controller
    {
        Employee1Context context;
        public HomeController()
        {
            context = new Employee1Context();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();

        }

        /*   #region--Create Method--
            public ActionResult Create()
            {

                Employee1Context context = new Employee1Context();
                ViewBag.StateList = context.StateList;
                var model = new Employee();
                return View(model);
            }


            [HttpPost]
            public ActionResult Create(Employee model)
            {
               // Employee1Context context = new Employee1Context ();

                if (ModelState.IsValid)
                {
                    context.EmpList.Add(model);
                    context.SaveChanges();
                    return RedirectToAction("Index");

                }
                ViewBag.StateList = context.StateList;
                return View(model);
            }
               #endregion */



        #region--GetData For DataTable--
        public ActionResult GetData()
        {
            using (Employee1Context context = new Employee1Context())
            {
                var EmployeeData = context.EmpList.OrderBy(a => a.EmployeeName).ToList();
                return Json(new { data = EmployeeData }, JsonRequestBehavior.AllowGet);
            }
        }

        #endregion


        #region--New PostMethod for Add Employees--
       
        [HttpGet]
        public ActionResult Create()
        {
            EmployeeViewModel employeeViewModel = new EmployeeViewModel();
            employeeViewModel.StateList = context.StateList.ToList();
            employeeViewModel.CityList = context.CityList.ToList();

            return View("Create", employeeViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                Employee employee = new Employee();
                employee.City = employeeViewModel.CityId;
                employee.State = employeeViewModel.StateId;
                employee.EmployeeName = employeeViewModel.EmployeeName;
                employee.Email = employeeViewModel.Email;
                employee.MaritialStatus = employeeViewModel.MaritialStatus;
                employee.PhoneNo = employeeViewModel.PhoneNo;

                context.EmpList.Add(employee);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            employeeViewModel.StateList = context.StateList.ToList();
            employeeViewModel.CityList = context.CityList.ToList();
            return View(employeeViewModel);

        }

        #endregion

        #region--Show Details--
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee stud = context.EmpList.Find(id);
            if (stud == null)
            {
                return HttpNotFound();
            }
            return View(stud);
        }
        #endregion

        #region--EditEmployee--
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee stud1 = context.EmpList.Find(id);
            if (stud1 == null)
            {
                return HttpNotFound();
            }
            return View(stud1);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeName,Email,Birthdate,Country,State,Address")] Employee stud)
        {
            if (ModelState.IsValid)
            {
                context.Entry(stud).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stud);
        }
#endregion

        #region--Get City--
        public ActionResult GetCity(int state)
        {
            Employee1Context context = new Employee1Context();

            var cities = context.CityList.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region--Delete Employee--
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee stud1 = context.EmpList.Find(id);
            if (stud1 == null)
            {
                return HttpNotFound();
            }
            return View(stud1);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(int? id, Employee stud1)
        {

            try
            {
                Employee emp = new Employee();
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
