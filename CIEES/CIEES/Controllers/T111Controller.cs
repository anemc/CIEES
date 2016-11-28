using CIEES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIEES.Controllers
{
    public class T111Controller : Controller
    {
        // GET: T111
        public ActionResult Index(int id)
        {
            var db = Utils.CIEESContext;
            var d = db.T111.Find(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }
        [HttpPost]
        public ActionResult Index(T111 u)
        {
            if (ModelState.IsValid)
            {
                var db = Utils.CIEESContext;
                db.Entry(u).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "T111");
            }
            return View(u);
        }
    }
}