using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        
        //create and update customer here
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (customer.Id == 0)
            {
                //_context.Customers.Add(customer);
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44318/customers/new");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<Customer>("https://localhost:44318/api/customers/", customer);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }

                    return Content("something went wrong");
                }
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.isSubscribeToNewsLetter = customer.isSubscribeToNewsLetter;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public IActionResult Edit(int id)
        {
            ViewData["H2"] = "Edit Customer";

            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customer == null)
            {
                return NotFound();
            }
            else
            {
                var viewModel = new NewCustomerViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipType.ToList()
                };

                return View("UpdateCustomerForm", viewModel);
            }

            
        }

        public IActionResult New()
        {

            ViewData["H2"] = "New Customer";
            
            var membershipTypes = _context.MembershipType.ToList();

            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm",viewModel);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

    }
}
