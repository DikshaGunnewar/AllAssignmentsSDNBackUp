using _09.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

       #region--GetData For DataTable--
        public ActionResult GetData()
         {
             using (StudentContext1 context = new StudentContext1())
             {
                 var EmployeeData = context.Students.OrderBy(a => a.FirstName).ToList();
                 return Json(new { data = EmployeeData }, JsonRequestBehavior.AllowGet);
             }
         }


    
        #endregion
    }
}