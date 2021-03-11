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
    }
}