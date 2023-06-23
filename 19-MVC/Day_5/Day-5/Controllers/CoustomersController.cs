using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Day_5.Data;
using Day_5.Models;

namespace Day_5.Controllers
{
    [RoutePrefix("cust")]
    public class CoustomersController : Controller
    {
        private Day_5Context db = new Day_5Context();

        
        // GET: Coustomers
        [Route("main")]
        public ActionResult Index()
        {
            return View(db.Coustomers.ToList());
        }

        // GET: Coustomers/Details/5
        [Route("info/{id:int:min(1)}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coustomer coustomer = db.Coustomers.Find(id);
            if (coustomer == null)
            {
                return HttpNotFound();
            }
            return View(coustomer);
        }

        // GET: Coustomers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Coustomers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,gender,Email,Mobile")] Coustomer coustomer)
        {
            if (ModelState.IsValid)
            {
                db.Coustomers.Add(coustomer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coustomer);
        }

        // GET: Coustomers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coustomer coustomer = db.Coustomers.Find(id);
            if (coustomer == null)
            {
                return HttpNotFound();
            }
            return View(coustomer);
        }

        // POST: Coustomers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CoustomerID,Name,gender,Email,Mobile")] Coustomer coustomer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coustomer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coustomer);
        }

        // GET: Coustomers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coustomer coustomer = db.Coustomers.Find(id);
            if (coustomer == null)
            {
                return HttpNotFound();
            }
            return View(coustomer);
        }

        // POST: Coustomers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Coustomer coustomer = db.Coustomers.Find(id);
            db.Coustomers.Remove(coustomer);
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
