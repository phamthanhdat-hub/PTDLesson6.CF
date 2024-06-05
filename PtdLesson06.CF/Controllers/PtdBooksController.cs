using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PtdLesson06.CF.Models;

namespace PtdLesson06.CF.Controllers
{
    public class PtdBooksController : Controller
    {
        private PtdBookStore db = new PtdBookStore();

        // GET: PtdBooks
        public ActionResult Index()
        {
            return View(db.PtdBooks.ToList());
        }

        // GET: PtdBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtdBook ptdBook = db.PtdBooks.Find(id);
            if (ptdBook == null)
            {
                return HttpNotFound();
            }
            return View(ptdBook);
        }

        // GET: PtdBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PtdBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PtdId,PtdBookId,PtdTitle,PtdAuthor,PtdYear,PtdPulisher,PtdPicture,PtdCategoryId")] PtdBook ptdBook)
        {
            if (ModelState.IsValid)
            {
                db.PtdBooks.Add(ptdBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ptdBook);
        }

        // GET: PtdBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtdBook ptdBook = db.PtdBooks.Find(id);
            if (ptdBook == null)
            {
                return HttpNotFound();
            }
            return View(ptdBook);
        }

        // POST: PtdBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PtdId,PtdBookId,PtdTitle,PtdAuthor,PtdYear,PtdPulisher,PtdPicture,PtdCategoryId")] PtdBook ptdBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ptdBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ptdBook);
        }

        // GET: PtdBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PtdBook ptdBook = db.PtdBooks.Find(id);
            if (ptdBook == null)
            {
                return HttpNotFound();
            }
            return View(ptdBook);
        }

        // POST: PtdBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PtdBook ptdBook = db.PtdBooks.Find(id);
            db.PtdBooks.Remove(ptdBook);
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
