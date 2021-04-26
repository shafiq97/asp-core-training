using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if(customer.Id == 0)
            {
                _context.Customers.Add(customer);
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

                return View("CustomerForm", viewModel);
            }

            
        }

        public IActionResult New()
        {
            var membershipTypes = _context.MembershipType.ToList();

            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm",viewModel);
        }

        public IActionResult Index()
        {

            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            
             
            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            return View(customer);
        }

    }
}
