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

            return Content("Guardada");
        }

        public ActionResult Lista()
        {
            var m = from x in Utils.CIEESContext.Users select x;
            return View(m);
        }

        
    }
}