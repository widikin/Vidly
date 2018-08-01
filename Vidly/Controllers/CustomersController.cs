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
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context= new ApplicationDbContext();
        }
        // GET: Customers
        public ActionResult Index()
        {

            var customers = _context.Customers.ToList();
          //  var customers = GetCustomer();
            return View(customers);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer>
            {
                  new Customer{ Id = 1,Name = "William" },
                  new Customer {   Id = 2, Name = "Huguette"},
                  new Customer { Id = 3, Name = "Widikin" }
            };
        }
    }
}