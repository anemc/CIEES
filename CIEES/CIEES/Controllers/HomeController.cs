﻿using System;
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
            var db = Utils.CIEESContext;
            db.Tables.Add(new Models.Tables { Nombre = "T111" });
            return View();
        }
    }
}