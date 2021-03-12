using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieProjectWithDatabase.Models;

namespace MovieProjectWithDatabase.Controllers
{
    public class MovieDatasController : Controller
    {
        private MoviesProjectEntities db = new MoviesProjectEntities();

        // GET: MovieDatas
        public ActionResult Index()
        {
            return View(db.MovieDatas.ToList());
        }

        // GET: MovieDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieData movieData = db.MovieDatas.Find(id);
            if (movieData == null)
            {
                return HttpNotFound();
            }
            return View(movieData);
        }

        // GET: MovieDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Genre,Price")] MovieData movieData)
        {
            if (ModelState.IsValid)
            {
                db.MovieDatas.Add(movieData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movieData);
        }

        // GET: MovieDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieData movieData = db.MovieDatas.Find(id);
            if (movieData == null)
            {
                return HttpNotFound();
            }
            return View(movieData);
        }

        // POST: MovieDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Genre,Price")] MovieData movieData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movieData);
        }

        // GET: MovieDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieData movieData = db.MovieDatas.Find(id);
            if (movieData == null)
            {
                return HttpNotFound();
            }
            return View(movieData);
        }

        // POST: MovieDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieData movieData = db.MovieDatas.Find(id);
            db.MovieDatas.Remove(movieData);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
