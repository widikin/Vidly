using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MoviesController()
        {
            _context= new ApplicationDbContext();
        }
        // GET: Movies
        public ActionResult Random()
        {
           // var movie= _context.Movies.Include()

            var movie = new Movie
            {
                Id = 1,
                Name = "Max Well"
            };


            var customers = new List<Customer> { new Customer { Id = 1, Name = "William" }, new Customer { Id = 2, Name = "Huguette" }, new Customer { Id = 3, Name = "Widikin" } };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

   
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm", viewModel);
        }


        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }


        public ActionResult New()
        {
            var genrer = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Genres = genrer
            };
            return View("MovieForm",viewModel);
        }


        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                //TryUpdateModel(customerInDb)

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.DateAdded = movie.DateAdded;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();

            //Redirect the User to Index in Customers(Controllers)
            return RedirectToAction("Index", "Movies");
        }


        /* public ActionResult Index(int? pageIndex, string sortBy)
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
         }*/

    }
}