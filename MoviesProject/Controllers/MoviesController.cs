using MoviesProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesProject.Controllers
{
    public class MoviesController : Controller
    {
        static private int counter = 5;
        // GET: Movies
        static List<Movie> allMovies = new List<Movie>()
        {
            new Movie(){Id=1,Title="Star Wars",Price=234,Genre="Fiction" },
            new Movie(){Id=2,Title="Back to the Future",Price=234,Genre="Sci Fi" },
            new Movie(){Id=3,Title="Predator",Price=234,Genre="Action" },
            new Movie(){Id=4,Title="The Matrix",Price=234,Genre="Action" },
            new Movie(){Id=5,Title="Jaws",Price=234,Genre="Thriller" }
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllMovies()
        {
            return View("AllMovies",allMovies);
        }

        public ActionResult Details(int Id)
        {
            var movie = allMovies.Find(c => c.Id == Id);
            return View("Details",movie);
        }

        // Edit using extra View
        //public ActionResult Edit(int Id)
        //{
        //    var movie = allMovies.Find(c => c.Id == Id);
        //    return View("Edit", movie);
        //}

        // Edit using extra View
        //[HttpPost]
        //public ActionResult Edit(Movie m)
        //{
        //    var movie = allMovies.Find(c => c.Id == m.Id);
        //    allMovies.Remove(movie);
        //    allMovies.Add(m);
        //    return RedirectToAction("AllMovies");
        //}

        public ActionResult Create()
        {
            return View("Create",new Movie { Id = 0});
        }

        [HttpPost]
        public ActionResult Create(Movie m)
        {
            if (m.Id <= 0)
            {
                m.Id = ++counter;
                allMovies.Add(m);
            }
            else
            {
                var movie = allMovies.Find(c => c.Id == m.Id);
                allMovies.Remove(movie);
                allMovies.Add(m);
            }
            return RedirectToAction("AllMovies");
        }

        public ActionResult Edit(int Id)
        {
            var movie = allMovies.Find(c => c.Id == Id);
            return View("Create", movie);
        }



        public ActionResult Delete(int Id)
        {
            allMovies.Remove(allMovies.Find(c => c.Id == Id));
            return RedirectToAction("AllMovies");
        }
    }
}