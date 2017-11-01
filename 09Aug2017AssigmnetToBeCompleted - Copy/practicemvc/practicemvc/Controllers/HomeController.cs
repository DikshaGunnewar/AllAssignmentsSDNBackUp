using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using practicemvc.Models;

namespace practicemvc.Controllers
{
    public class HomeController : Controller
    {
        MyContext context = new MyContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            var MemberType = context.MemberTypes.ToList();
            var viewModel = new NewDataViewModel
            {
                MemberTypes = MemberType
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create(dbase db)
        {
            context.dbases.Add(db);
            context.SaveChanges();
            return RedirectToAction("Index", "dbases");
        }
    }
}