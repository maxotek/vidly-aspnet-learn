﻿#region Copyright

// Maxotek CONFIDENTIAL INFORMATION
// © 2007-2016 Maxotek Inc.
// All Rights Reserved
//                                                                   
// This program contains confidential and proprietary information   
// of the Maxotek, Inc.  Any reproduction, disclosure, or use       
// in whole or in part is expressly prohibited, except as may be    
// specifically authorized by prior written agreement.

#endregion

#region Imports

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using vidly_aspnet_learn.Models;
using vidly_aspnet_learn.ViewModels;

#endregion

namespace vidly_aspnet_learn.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie
            {
                Name = "Shrek!"
            };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var randomMovieViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(randomMovieViewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex == null)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            var movies = GetMovies();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).FirstOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        [Route("movies/released/{year:range(2015,2016)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.Include(m => m.Genre);
        }
    }
}