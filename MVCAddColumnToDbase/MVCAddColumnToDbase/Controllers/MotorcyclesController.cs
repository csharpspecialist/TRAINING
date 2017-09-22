using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCAddColumnToDbase.Models;

namespace MVCAddColumnToDbase.Controllers
{
    public class MotorcyclesController : Controller
    {
        private MotorcycleDBContext db = new MotorcycleDBContext();

        // GET: Motorcycles
        //public ActionResult Index()
        //{
        //    return View(db.Bikes.ToList());
        //}

        //public ActionResult Index(string searchString)
        //{
        //    var movies = from m in db.Bikes
        //                 select m;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        movies = movies.Where(s => s.Manufacturer.Contains(searchString));
        //    }

        //    return View(movies);
        //}

            public ActionResult Hiding()
        {

            return View();
        }

        public ActionResult Index(string searchString)
        {
            var movies = from m in db.Bikes
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Style.Contains(searchString));
            }

            return View(movies);
        }





        //public ActionResult Index(string bikeGenre, string searchString)
        //{
        //    var GenreLst = new List<string>();

        //    var GenreQry = from d in db.Bikes
        //                   orderby d.Manufacturer
        //                   select d.Manufacturer;

        //    GenreLst.AddRange(GenreQry.Distinct());
        //    ViewBag.bikeGenre = new SelectList(GenreLst);

        //    var movies = from m in db.Bikes
        //                 select m;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        movies = movies.Where(s => s.Style.Contains(searchString));
        //    }

        //    if (!string.IsNullOrEmpty(bikeGenre))
        //    {
        //        movies = movies.Where(x => x.Style == bikeGenre);
        //    }

        //    return View(movies);
        //}


        // GET: Motorcycles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorcycle motorcycle = db.Bikes.Find(id);
            if (motorcycle == null)
            {
                return HttpNotFound();
            }
            return View(motorcycle);
        }

        // GET: Motorcycles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motorcycles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Manufacturer,ReleaseDate,Style,CC,Price")] Motorcycle motorcycle)
        {
            if (ModelState.IsValid)
            {
                db.Bikes.Add(motorcycle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(motorcycle);
        }

        // GET: Motorcycles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorcycle motorcycle = db.Bikes.Find(id);
            if (motorcycle == null)
            {
                return HttpNotFound();
            }
            return View(motorcycle);
        }

        // POST: Motorcycles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Manufacturer,ReleaseDate,Style,CC,Price")] Motorcycle motorcycle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(motorcycle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motorcycle);
        }

        // GET: Motorcycles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorcycle motorcycle = db.Bikes.Find(id);
            if (motorcycle == null)
            {
                return HttpNotFound();
            }
            return View(motorcycle);
        }

        // POST: Motorcycles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Motorcycle motorcycle = db.Bikes.Find(id);
            db.Bikes.Remove(motorcycle);
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
