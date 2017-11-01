using DikshaAssignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DikshaAssignment3.Controllers
{
    public class HomeController : Controller
    {
        StudentContext1 context;

        #region--Home Constructor--
        public HomeController()
        {
            context = new StudentContext1();
        }
        #endregion

        #region--get Home--
        // GET: Home
        public ActionResult Index()
        {
            var student = context.Student1s.ToList();
            return View(student);
        }
        #endregion

        #region--Student Form--
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student1 student)
        {
            if (ModelState.IsValid)
            {
                context.Student1s.Add(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);

        }
        #endregion

        #region--Student Details--
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student1 c1 = context.Student1s.Find(id);
            if (c1 == null)
            {
                return HttpNotFound();
            }
            return View(c1);
        }
        #endregion
        protected void ClearTextBoxes(Control p1)
        {
            foreach (Control ctrl in p1.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox t = ctrl as TextBox;

                    if (t != null)
                    {
                        t.Text = String.Empty;
                    }
                }
                else
                {
                    if (ctrl.Controls.Count > 0)
                    {
                        ClearTextBoxes(ctrl);
                    }
                }
            }
        }
    }
}