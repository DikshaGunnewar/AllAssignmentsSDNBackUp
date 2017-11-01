using LastCode.Models;
using LastCode.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LastCode.Controllers
{
    public class CustomerController : Controller
    {

        private CustomerContext db;
        public CustomerController()
        {
            db = new CustomerContext();
        }
        public ActionResult New()
        {
            var st = db.Countries.ToList();
            var mt = db.States.ToList();
            var viewModel = new NameCountryState
            {
                Customer = new Customer(),
                Countries = st,
                States = mt

            };

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NameCountryState
                {
                    Customer = customer,
                    Countries = db.Countries.ToList(),
                    States = db.States.ToList()
                };

                return View("New", viewModel);
            }

            if (customer.Id == 0)
                db.Customers.Add(customer);
            else
            {
                var customerInDb = db.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.Email = customer.Email;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.CountryName = customer.CountryName;
                customerInDb.StateName = customer.StateName;
                customerInDb.Address = customer.Address;


            }

            db.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }
    }
}