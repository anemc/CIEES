using CIEES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIEES.Controllers
{
    public class DatesController : Controller
    {
        // GET: Dates
        public ActionResult Fechas()
        {
            return View();
        }

        public ActionResult Guardar(Dates d)
        {
            var db = Utils.CIEESContext;
            db.Dates.Add(d);
            db.SaveChanges();
            return RedirectToAction("Autoevaluacion", "Otras");
        }
    }
}