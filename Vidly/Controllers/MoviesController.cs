using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie
            {
                Id = 1,
                Name = "Max Well"
            };


            var  customers = new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "William"
                    
                },
                new Customer
                {
                    Id = 2,
                    Name = "Huguette"
                    
                },
                new Customer
                {
                    Id = 3,
                    Name = "Widikin"
                    
                }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)

                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("pageIdex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("movie/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}