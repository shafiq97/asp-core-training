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
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        // GET: /Movies/Random
        public IActionResult Random()
        {
            //create instance of movie model
            var movie = new Movie() { Name = "Shrek" };

            var customer = new List<Customer>
            {
                new Customer {Name = "Shafiq"},
                new Customer {Name = "Fahim"},
                new Customer {Name = "Lulu"},
                
            };

            //create viewmodel object
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customer
            };

            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        
        public IActionResult Index()
        {

            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        /*public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex = {0} & sortBy = {1}", pageIndex, sortBy));
        }*/

        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public IActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);
            return View(movie);
        }
    }
}
