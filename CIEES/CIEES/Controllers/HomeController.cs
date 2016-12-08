using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIEES.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["User"] != null)
            {
                return RedirectToAction("Autoevaluacion", "Otras");
            }
            var db = Utils.CIEESContext;
            db.Pdfs.Add(new Models.Pdfs { Nombre = "T111" });
            return View();
        }

        public ActionResult Logout()
        {
            Session["User"] = null;
            Session["Type"] = null;
            Session["Id"] = null;
            Session["Ruta"] = null;
            return RedirectToAction("Inicio", "Home");
        }

        public ActionResult Inicio()
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}