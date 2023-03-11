using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lê_Hồng_Cát_Tường_2011063819.Models;

namespace Lê_Hồng_Cát_Tường_2011063819.Controllers
{
    public class CoursessesController : Controller
    {
        private BigSchool db = new BigSchool();

        // GET: Coursesses
        public ActionResult Index()
        {
            var coursesses = db.Coursesses.Include(c => c.categoriess);
            return View(coursesses.ToList());
        }

        // GET: Coursesses/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coursess coursess = db.Coursesses.Find(id);
            if (coursess == null)
            {
                return HttpNotFound();
            }
            return View(coursess);
        }

        // GET: Coursesses/Create
        public ActionResult Create()
        {
            ViewBag.Categori = new SelectList(db.categoriesses, "Categori", "name");
            return View();
        }

        // POST: Coursesses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "place,Date,time,Categori")] Coursess coursess)
        {
            if (ModelState.IsValid)
            {
                db.Coursesses.Add(coursess);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Categori = new SelectList(db.categoriesses, "Categori", "name", coursess.Categori);
            return View(coursess);
        }

        // GET: Coursesses/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coursess coursess = db.Coursesses.Find(id);
            if (coursess == null)
            {
                return HttpNotFound();
            }
            ViewBag.Categori = new SelectList(db.categoriesses, "Categori", "name", coursess.Categori);
            return View(coursess);
        }

        // POST: Coursesses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "place,Date,time,Categori")] Coursess coursess)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coursess).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Categori = new SelectList(db.categoriesses, "Categori", "name", coursess.Categori);
            return View(coursess);
        }

        // GET: Coursesses/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coursess coursess = db.Coursesses.Find(id);
            if (coursess == null)
            {
                return HttpNotFound();
            }
            return View(coursess);
        }

        // POST: Coursesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Coursess coursess = db.Coursesses.Find(id);
            db.Coursesses.Remove(coursess);
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
