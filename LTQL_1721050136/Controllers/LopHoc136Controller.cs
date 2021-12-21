using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050136.Models;

namespace LTQL_1721050136.Controllers
{
    public class LopHoc136Controller : Controller
    {
        private LTQLDb db = new LTQLDb();

        // GET: LopHoc136
        public ActionResult Index()
        {
            return View(db.LopHoc136s.ToList());
        }

        // GET: LopHoc136/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc136 lopHoc136 = db.LopHoc136s.Find(id);
            if (lopHoc136 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc136);
        }

        // GET: LopHoc136/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LopHoc136/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLop,TenLop")] LopHoc136 lopHoc136)
        {
            if (ModelState.IsValid)
            {
                db.LopHoc136s.Add(lopHoc136);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lopHoc136);
        }

        // GET: LopHoc136/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc136 lopHoc136 = db.LopHoc136s.Find(id);
            if (lopHoc136 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc136);
        }

        // POST: LopHoc136/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLop,TenLop")] LopHoc136 lopHoc136)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lopHoc136).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lopHoc136);
        }

        // GET: LopHoc136/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc136 lopHoc136 = db.LopHoc136s.Find(id);
            if (lopHoc136 == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc136);
        }

        // POST: LopHoc136/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LopHoc136 lopHoc136 = db.LopHoc136s.Find(id);
            db.LopHoc136s.Remove(lopHoc136);
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
