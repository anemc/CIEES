using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIEES.Controllers
{
    public class OtrasController : Controller
    {
        // GET: Otras
        public ActionResult Autoevaluacion()
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}