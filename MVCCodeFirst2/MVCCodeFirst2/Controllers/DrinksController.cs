using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCCodeFirst2.Models;

namespace MVCCodeFirst2.Controllers
{
    public class DrinksController : Controller
    {
        private MenuDBContext db = new MenuDBContext();

        // GET: Drinks
        public ActionResult Index()
        {
            return View(db.Booze.ToList());
        }

        // GET: Drinks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drinks drinks = db.Booze.Find(id);
            if (drinks == null)
            {
                return HttpNotFound();
            }
            return View(drinks);
        }

        // GET: Drinks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drinks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DrinkID,DrinkName,DrinkGlass,DrinkGenre,Price")] Drinks drinks)
        {
            if (ModelState.IsValid)
            {
                db.Booze.Add(drinks);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(drinks);
        }

        // GET: Drinks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drinks drinks = db.Booze.Find(id);
            if (drinks == null)
            {
                return HttpNotFound();
            }
            return View(drinks);
        }

        // POST: Drinks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DrinkID,DrinkName,DrinkGlass,DrinkGenre,Price")] Drinks drinks)
        {
            if (ModelState.IsValid)
            {
                db.Entry(drinks).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(drinks);
        }

        // GET: Drinks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drinks drinks = db.Booze.Find(id);
            if (drinks == null)
            {
                return HttpNotFound();
            }
            return View(drinks);
        }

        // POST: Drinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Drinks drinks = db.Booze.Find(id);
            db.Booze.Remove(drinks);
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
