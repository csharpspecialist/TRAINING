﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDbaseFirst4.Models;

namespace MVCDbaseFirst4.Controllers
{
    public class NovelsController : Controller
    {
        private NovelEntities db = new NovelEntities();

        // GET: Novels
        public ActionResult Index()
        {
            return View(db.Novels.ToList());
        }

        // GET: Novels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novel novel = db.Novels.Find(id);
            if (novel == null)
            {
                return HttpNotFound();
            }
            return View(novel);
        }

        // GET: Novels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Novels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Author,Pages,Genre,Price")] Novel novel)
        {
            if (ModelState.IsValid)
            {
                db.Novels.Add(novel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(novel);
        }

        // GET: Novels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novel novel = db.Novels.Find(id);
            if (novel == null)
            {
                return HttpNotFound();
            }
            return View(novel);
        }

        // POST: Novels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Author,Pages,Genre,Price")] Novel novel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(novel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(novel);
        }

        // GET: Novels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Novel novel = db.Novels.Find(id);
            if (novel == null)
            {
                return HttpNotFound();
            }
            return View(novel);
        }

        // POST: Novels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Novel novel = db.Novels.Find(id);
            db.Novels.Remove(novel);
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


        public ActionResult Page()
        {
            return View();
        }


        public string Showoff()
        {
            string nice = "We R Here to party";

            return nice;
        }


    }
}
