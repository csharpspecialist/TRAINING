using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDbaseFirstFreeHand.Models;

namespace MVCDbaseFirstFreeHand.Controllers
{
    public class WheelsController : Controller
    {
        private WheelsDbContext db = new WheelsDbContext();

        // GET: Wheels
        public ActionResult Index()
        {
            return View(db.Fast.ToList());
        }

        // GET: Wheels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wheels wheels = db.Fast.Find(id);
            if (wheels == null)
            {
                return HttpNotFound();
            }
            return View(wheels);
        }

        // GET: Wheels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wheels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Year,Make,Model,Color,Engine")] Wheels wheels)
        {
            if (ModelState.IsValid)
            {
                db.Fast.Add(wheels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wheels);
        }

        // GET: Wheels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wheels wheels = db.Fast.Find(id);
            if (wheels == null)
            {
                return HttpNotFound();
            }
            return View(wheels);
        }

        // POST: Wheels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Year,Make,Model,Color,Engine")] Wheels wheels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wheels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wheels);
        }

        // GET: Wheels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wheels wheels = db.Fast.Find(id);
            if (wheels == null)
            {
                return HttpNotFound();
            }
            return View(wheels);
        }

        // POST: Wheels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Wheels wheels = db.Fast.Find(id);
            db.Fast.Remove(wheels);
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
