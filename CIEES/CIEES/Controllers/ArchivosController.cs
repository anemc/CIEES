using Rotativa;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIEES.Controllers
{
    public class ArchivosController : Controller
    {
        // GET: Archivos

        public ActionResult Subir()
        {
            return View( ViewBag.ShouldClose = false);
        }
        [HttpPost]
        public ActionResult Subir(foto foto)
        {
            foreach (var file in foto.files)
            {
                string d = Session["Ruta"].ToString();
                if (!Directory.Exists(d))
                {
                    DirectoryInfo di = Directory.CreateDirectory(Server.MapPath(d));

                }
                // Some browsers send file names with full path. We only care about the file name.
                var fileName = Path.GetFileName(file.FileName);

                var destinationPath = Path.Combine(
                    Server.MapPath(d), fileName);
                file.SaveAs(destinationPath);
            }
            return View(ViewBag.ShouldClose = true);
        }

        public ActionResult Ver()
        {
            string d = Session["Ruta"].ToString();
            if (!Directory.Exists(d))
            {
                DirectoryInfo di = Directory.CreateDirectory(Server.MapPath(d));
            }
            DirectoryInfo dirInfo = Directory.CreateDirectory(Server.MapPath(d));
            List<FileInfo> files = dirInfo.GetFiles().ToList();
            return View(files);
        }

        public ActionResult Eliminar()
        {
            string fullPath = Request.MapPath(Session["Ruta"].ToString() + "/" + Session["FileName"].ToString());
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }
            return RedirectToAction("Ver");
        }

        public class foto
        {
            public IEnumerable<HttpPostedFileBase> files { get; set; }
        }
    }
}