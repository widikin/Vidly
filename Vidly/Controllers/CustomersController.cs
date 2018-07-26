using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>{  new Customer{ Id = 1,Name = "William" }, new Customer {   Id = 2, Name = "Huguette"}, new Customer { Id = 3, Name = "Widikin" }};
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customers = new List<Customer> { new Customer { Id = 1, Name = "William" }, new Customer { Id = 2, Name = "Huguette" }, new Customer { Id = 3, Name = "Widikin" } };
            var customer = customers.SingleOrDefault(c => c.Id == id);
            return View(customer);
        }
    }
}