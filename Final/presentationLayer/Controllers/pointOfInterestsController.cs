using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using businessLogicLayer;
using databaseAccessLayer;

namespace presentationLayer.Controllers
{
    public class pointOfInterestsController : Controller
    {
        private pointOfInterestContext db = new pointOfInterestContext();

        // GET: pointOfInterests
        public ActionResult Index()
        {
            return View(db.pointOfInterests.ToList());
        }

        // GET: pointOfInterests/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pointOfInterest pointOfInterest = db.pointOfInterests.Find(id);
            if (pointOfInterest == null)
            {
                return HttpNotFound();
            }
            return View(pointOfInterest);
        }

        // GET: pointOfInterests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: pointOfInterests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] pointOfInterest pointOfInterest)
        {
            if (ModelState.IsValid)
            {
                pointOfInterest.Id = Guid.NewGuid();
                db.pointOfInterests.Add(pointOfInterest);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pointOfInterest);
        }

        // GET: pointOfInterests/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pointOfInterest pointOfInterest = db.pointOfInterests.Find(id);
            if (pointOfInterest == null)
            {
                return HttpNotFound();
            }
            return View(pointOfInterest);
        }

        // POST: pointOfInterests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] pointOfInterest pointOfInterest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pointOfInterest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pointOfInterest);
        }

        // GET: pointOfInterests/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pointOfInterest pointOfInterest = db.pointOfInterests.Find(id);
            if (pointOfInterest == null)
            {
                return HttpNotFound();
            }
            return View(pointOfInterest);
        }

        // POST: pointOfInterests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            pointOfInterest pointOfInterest = db.pointOfInterests.Find(id);
            db.pointOfInterests.Remove(pointOfInterest);
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
