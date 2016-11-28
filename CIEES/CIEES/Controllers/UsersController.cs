using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CIEES.Models;

namespace CIEES.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Nuevo()
        {
            return View();
        }

        public ActionResult Guardar(Users u)
        {
            var db = Utils.CIEESContext;
            db.Users.Add(u);
            db.SaveChanges();

            return RedirectToAction("Lista", "Users");
        }

        public ActionResult Lista()
        {
            var db = Utils.CIEESContext;
            //var m = from x in Utils.CIEESContext.Users select x;
            return View(db.Users.ToList());
        }

        public ActionResult Detalles(int id)
        {
            var db = Utils.CIEESContext;
            var d = db.Users.Find(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }

        public ActionResult Editar(int id)
        {
            var db = Utils.CIEESContext;
            var d = db.Users.Find(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }
        [HttpPost]
        public ActionResult Editar(Users u)
        {
            if (ModelState.IsValid)
            {
                var db = Utils.CIEESContext;
                db.Entry(u).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Lista");
            }
            return View(u);
        }

        // GET: /Movies/Delete/5
        public ActionResult Borrar(int id)
        {
            var db = Utils.CIEESContext;
            var d = db.Users.Find(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("Borrar")]
        [ValidateAntiForgeryToken]
        public ActionResult BorrarConfirmacion(int id)
        {
            var db = Utils.CIEESContext;
            var d = db.Users.Find(id);
            db.Users.Remove(d);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }

        public ActionResult Modpass(int id)
        {
            var db = Utils.CIEESContext;
            var d = db.Users.Find(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }
        [HttpPost]
        public ActionResult Modpass(Users u)
        {
            if (ModelState.IsValid)
            {
                var db = Utils.CIEESContext;
                db.Entry(u).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Lista");
            }
            return View(u);
        }
    }
}