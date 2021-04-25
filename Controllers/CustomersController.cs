using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {

            var customers = new List<Customer>
            {
                new Customer{Name="John Smith", Id = 1},
                new Customer{Name="Mary Williams", Id = 2}

            };
             
            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id=1, Name="John Smith"},
                new Customer {Id=2, Name="Marry William"}
            };
        }
    }
}
