using App.Data;
using App.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using static App.Service.EmployeeService;

namespace Assignment6_12Aug_Diksha.Controllers
{
    public class EmployeeController : Controller
    {
       
        private EmployeeContext db = new EmployeeContext();

        #region--Get Index
        // GET: Employee
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }
        #endregion


        #region--Get Details--
        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee emp = db.Employees.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }
        #endregion


        /*  #region--Get Method for Create Main--
          // GET: Employee/Create
          public ActionResult Create()
          {
              EmployeeContext db = new EmployeeContext();

              ViewBag.States = db.States;
              var model = new Employee();
              return View(model);
              //return View();
          }
          #endregion

          #region--Post Method for Create--
          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Create([Bind(Include = "Id,Name,Phone,Email,MaritialStatus,State,City")] Employee emp)
          {
              if (ModelState.IsValid)
              {
                  db.Employees.Add(emp);
                  db.SaveChanges();
                  return RedirectToAction("Index");
              }
              ViewBag.States = db.States;
              return View(emp);         
          }
          #endregion*/

        #region--Get Method for Create Practice--
        // GET: Employee/Create
        public ActionResult Create()
        {
            EmployeeContext db = new EmployeeContext();

            ViewBag.States = db.States;
            var model = new Employee();
            return View(model);
            //return View();
        }
        #endregion

        #region--Post Method for Create--
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Phone,Email,MaritialStatus,State,City,image")] Employee emp, HttpPostedFileBase imageFile, string cmd)
        {
            if (ModelState.IsValid)
            {
                if (imageFile != null && imageFile.ContentLength > 0)
                {
                    /*var fileName = Path.GetFileName(imageFile.FileName);
                    
                    emp.image = fileName;
                    db.Employees.Add(emp);
                    db.SaveChanges();
                    
                    var path = Path.Combine(Server.MapPath("~/Content/img/"));
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                       imageFile.SaveAs(path + "/" + fileName);*/

                    var fileName = Path.GetFileName(imageFile.FileName);
                    var guid = Guid.NewGuid().ToString();
                    var path = Path.Combine(Server.MapPath("~/Content/img/"), guid + fileName);
                    imageFile.SaveAs(path);
                    string fl = path.Substring(path.LastIndexOf("\\"));
                    string[] split = fl.Split('\\');
                    string newpath = split[1];
                    string imagepath = "~/Content/img/" + newpath;

                    emp.image = imagepath;
                    db.Employees.Add(emp);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            ViewBag.States = db.States;
            return View(emp);
        }
        #endregion

       #region--Get Method for Edit Main--
          // GET: Employee/Edit/id
          public ActionResult Edit(int? id)
          {
              if (id == null)
              {
                  return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
              }
             Employee emp = db.Employees.Find(id);
              if (emp == null)
              {
                  return HttpNotFound();
              }
              ViewBag.States = db.States;
              return View(emp);
          }
          #endregion


          #region--Post Method for Edit--
          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Edit([Bind(Include = "Id,Name,Phone,Email,MaritialStatus,State,City")] Employee emp)
          {
              if (ModelState.IsValid)
              {
                  db.Entry(emp).State = EntityState.Modified;
                  db.SaveChanges();
                  return RedirectToAction("Index");
              }
              ViewBag.States = db.States;
              return View(emp);       
          }
          #endregion 

        /*  #region--Get Method for Edit--
       // GET: Employee/Edit/id
    public ActionResult Edit(int? id)
       {
           if (id == null)
           {
               return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
           }
           Employee emp = db.Employees.Find(id);
           if (emp == null)
           {
               return HttpNotFound();
           }
           ViewBag.States = db.States;
           return View(emp);
       }
       #endregion


       #region--Post Method for Edit--
       [HttpPost]
       [ValidateAntiForgeryToken]
       public ActionResult Edit([Bind(Include = "Id,Name,Phone,Email,MaritialStatus,State,City,image")] Employee emp, HttpPostedFileBase imageFile)
       {
           if (ModelState.IsValid)
           {
               var model = db.Employees.Find(emp.Id);
               string oldfilePath = model.image;
               if (imageFile != null && imageFile.ContentLength > 0)
               {
                   var fileName = Path.GetFileName(imageFile.FileName);
                   string path = System.IO.Path.Combine(
                   Server.MapPath("~/Content/img"), fileName);
                   imageFile.SaveAs(path);
                   model.image = "/Content/img" + imageFile.FileName;
                   string fullPath = Request.MapPath("~" + oldfilePath);
                   if (System.IO.File.Exists(fullPath))
                   {
                       System.IO.File.Delete(fullPath);
                   }
               }

               model.image = emp.image;

               db.Entry(emp).State = EntityState.Modified;
               db.SaveChanges();
               return RedirectToAction("Index");
           }
           ViewBag.States = db.States;
           return View(emp);
       }
       #endregion */

        #region--Get Method for Delete--
        // GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           Employee product = db.Employees.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        #endregion

        #region--Post Method for Delete--

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee product = db.Employees.Find(id);
            db.Employees.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion


        #region--FillCity Method for dropdown list--
        public ActionResult FillCity(int state)
        {
            EmployeeContext db = new EmployeeContext();

            var cities = db.Cities.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region--- Dispose Method-
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion
    }
}
