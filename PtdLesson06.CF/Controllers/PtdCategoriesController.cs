using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PtdLesson06.CF.Models;

namespace PtdLesson06.CF.Controllers
{
    public class PtdCategoriesController : Controller
    {
        private static PtdBookStore ptdDb;
        public PtdCategoriesController()
        {
            ptdDb = new PtdBookStore();
        }
        // GET: PtdCategories
        public ActionResult PtdIndex()
        {
            /*
             * khoi tao DbContext
             * Ef tim thong tin ket noi
             * sau do tao csdl
             */
            //PtdBookStore ptdDb = new PtdBookStore();
            var ptdCategories = ptdDb.PtdCategories.ToList();
            return View(ptdCategories);
        }
        public ActionResult PtdCreate()
        {
            var ptdCategory = new PtdCategory();
            return View(ptdCategory);
        }
        [HttpPost]
        public ActionResult PtdCreate(PtdCategory ptdCategory)
        {
            ptdDb.PtdCategories.Add(ptdCategory);
            ptdDb.SaveChanges();
            return RedirectToAction("PtdIndex");
        }
    }
}