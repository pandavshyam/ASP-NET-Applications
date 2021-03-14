using MovieProjectWithCodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieProjectWithCodeFirstApproach.Controllers
{
    public class MoviesController : Controller
    {
        private MovieProjectEntities db;
        // GET: Movies

        public MoviesController()
        {
            db = new MovieProjectEntities();
        }

        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }

        public ActionResult Create()
        {
            return View("Create", new Movie { Id = 0});
        }

        [HttpPost]
        public ActionResult Create(Movie m)
        {
            if (m.Id <=0)
            {
                db.Movies.Add(m);
            }
            else
            {
                db.Entry(m).State = System.Data.Entity.EntityState.Modified;
            }
            
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? Id)
        {
            Movie m = db.Movies.Find(Id);
            return View("Create", m);
        }

        public ActionResult Delete(int? Id)
        {
            Movie m = db.Movies.Find(Id);
            db.Movies.Remove(m);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}