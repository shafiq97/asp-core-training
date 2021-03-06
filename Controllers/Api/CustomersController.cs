using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET  /api/customers
        public IEnumerable<Customer> GetCustomers()
        {
            var result = _context.Customers
                .Include(c => c.MembershipType)
                .ToList();
            return result;
            
        }

        // GET /api/customers/1
        [HttpGet("/api/customers/{id}")]
        public Customer GetCustomer(int id)
        {
            var customer =  _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customer == null)
            {
                throw new Exception("NotFound");
            }

            return customer;
        }


        // POST /api/customers
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if(!ModelState.IsValid)
            {
                throw new Exception("BadRequest");
            }

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }

        // PUT /api/customers/1
        [HttpPut("/api/customers/{id}")]
        public void UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new Exception("BadRequest");
            }

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                throw new Exception("NotFound");
            }

            customerInDb.Name = customer.Name;
            customerInDb.BirthDate = customer.BirthDate;
            customerInDb.isSubscribeToNewsLetter = customer.isSubscribeToNewsLetter;
            customerInDb.MembershipTypeId = customer.MembershipTypeId;

            _context.SaveChanges();
        }

        // DELETE /api/customers/1
        [HttpDelete("/api/customers/{id}")]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                throw new Exception("NotFound");
            }

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

        }
    }
}
