using PracticeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeAssignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        #region--Fill City--
        public ActionResult Create()
        {

            InfoClientContext db = new InfoClientContext();
            ViewBag.StateList = db.StateList;
            var model = new InfoClient();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(InfoClient model)
        {
            InfoClientContext db = new InfoClientContext();

            if (ModelState.IsValid)
            {
                db.InfoClients.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            ViewBag.StateList = db.StateList;
            return View(model);
        }
        #endregion

        #region--Fill City--
        public ActionResult FillCity(int state)
        {
            InfoClientContext db = new InfoClientContext();

            var cities = db.CityList.Where(c => c.StateId == state);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}