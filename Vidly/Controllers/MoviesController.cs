using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ApplicationDbContext _context { get; set; }

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();
            if (movies == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(movies);
            }
        }
        public ActionResult Details(int Id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(c => c.Id == Id);
           
            return View(movie);
            
        }
        public ActionResult New()
        {
            var genre = _context.Genres;
            var viewModel = new NewMovieViewModel
            {
                Genres = genre
            };
            return View("MovieForm", viewModel);
            
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            

           
            return RedirectToAction("Index","Movies");
        }
        public ActionResult Edit(int id)
        {


            return View("MovieForm");
        }

    }
}