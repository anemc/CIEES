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
        public ActionResult Nuevo(Users u)
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult Guardar(Users u)
        {
            var db = Utils.CIEESContext;
            var user = db.Users.Where(x => x.Usuario == u.Usuario).FirstOrDefault();
            if (user != null)
            {
                return Content("El usuario ya existe.");
            }
            db.Users.Add(u);
            db.SaveChanges();

            return RedirectToAction("Lista", "Users");
        }

        public ActionResult Lista()
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var db = Utils.CIEESContext;
            //var m = from x in Utils.CIEESContext.Users select x;
            return View(db.Users.ToList());
        }

        public ActionResult Detalles(int id)
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
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
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
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
                var d = db.Users.Find(u.UsuarioId);
                d.Nombre = u.Nombre;
                d.ApellidoP = u.ApellidoP;
                d.ApellidoM = u.ApellidoM;
                d.Usuario = u.Usuario;
                d.Contrasena = u.Contrasena;
                d.Correo = u.Correo;
                d.Tipo = u.Tipo;
                db.SaveChanges();
                return RedirectToAction("Lista");
            }
            return View(u);
        }

        // GET: /Movies/Delete/5
        public ActionResult Borrar(int id)
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
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
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
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
                var d = db.Users.Find(new object[] { u.UsuarioId });
                d.Contrasena = u.Contrasena;
                d.Nombre = u.Nombre;
                db.SaveChanges();
                return RedirectToAction("Lista");
            }
            return View(u);
        }

        [HttpPost]
        public ActionResult Val(Users u)
        {
            var db = Utils.CIEESContext;
            var user = db.Users.Where(x => x.Usuario == u.Usuario).FirstOrDefault();
            //var pass = db.Users.Where(x => x.Contrasena == u.Contrasena).FirstOrDefault();
            if (user == null || user.Contrasena!=u.Contrasena)
            {
                return Content("El usuario o contraseña son incorrectos.");
            }
            Session["User"] = user.Usuario;
            Session["Type"] = user.Tipo;
            Session["Id"] = user.UsuarioId;
            return RedirectToAction("Autoevaluacion", "Otras");
        }
    }
}