﻿using CIEES.Models;
using Rotativa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIEES.Controllers
{
    public class T111Controller : Controller
    {
        // GET: T111
        public ActionResult Index(int id, bool pdf = false)
        {
            Session["Pdf"] = 1;
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var db = Utils.CIEESContext;
            var d = db.T111.Find(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            Session["Ruta"] = "~/Content/Informatica/Eje1/Cat1/T111";
            return View(d);
        }
        [HttpPost]
        public ActionResult Index(T111 u)
        {
            if (ModelState.IsValid)
            {
                var db = Utils.CIEESContext;
                var d = db.T111.Find(u.T111Id);
                d.F_Aprob = u.F_Aprob;
                d.F_Mod = DateTime.Today;
                d.Mision = u.Mision;
                d.Objetivos = u.Objetivos;
                d.Resp1 = u.Resp1;
                d.Resp2 = u.Resp2;
                d.Resp3 = u.Resp3;
                d.Resp4 = u.Resp4;
                d.Vision = u.Vision;
                db.SaveChanges();
                return RedirectToAction("Index", "T111");
            }
            return View(u);
        }

        public ActionResult ExportaPDF()
        {

            var root = Server.MapPath("~/Content/Pdfs");
            var pdfName = "Indicador 1.1.1.pdf";
            var path = System.IO.Path.Combine(root, pdfName);
            path = System.IO.Path.GetFullPath(path);
            Session["Pdf"] = 0;
            return new ViewAsPdf("Index")
            {
                SaveOnServerPath = path
            };

        }
    }
}