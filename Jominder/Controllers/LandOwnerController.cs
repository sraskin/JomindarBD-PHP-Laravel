using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Jominder.Models;

namespace Jominder.Controllers
{
    public class LandOwnerController : Controller
    {
        private JominderDBEntities db = new JominderDBEntities();

        // GET: /LandOwner/
        public ActionResult Index()
        {
            return View(db.LandOwner.ToList());
        }

        // GET: /LandOwner/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LandOwner landowner = db.LandOwner.Find(id);
            if (landowner == null)
            {
                return HttpNotFound();
            }
            return View(landowner);
        }

        // GET: /LandOwner/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /LandOwner/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ID,Name,Contact,Location,Status,Amount,Demand,Lat,Lng,Verification,RegNo,Other")] LandOwner landowner)
        {
            if (ModelState.IsValid)
            {
                db.LandOwner.Add(landowner);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(landowner);
        }

        // GET: /LandOwner/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LandOwner landowner = db.LandOwner.Find(id);
            if (landowner == null)
            {
                return HttpNotFound();
            }
            return View(landowner);
        }

        // POST: /LandOwner/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ID,Name,Contact,Location,Status,Amount,Demand,Lat,Lng,Verification,RegNo,Other")] LandOwner landowner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(landowner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(landowner);
        }

        // GET: /LandOwner/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LandOwner landowner = db.LandOwner.Find(id);
            if (landowner == null)
            {
                return HttpNotFound();
            }
            return View(landowner);
        }

        // POST: /LandOwner/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LandOwner landowner = db.LandOwner.Find(id);
            db.LandOwner.Remove(landowner);
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
