﻿using CIEES.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CIEES
{
    public static class Utils
    {
        private static MyDbContext db;

        public static MyDbContext CIEESContext
        {
            get
            {
                if (db == null)
                {
                    db = new MyDbContext();
                }

                return db;
            }
        }
    }
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var db = Utils.CIEESContext;
        }
    }
}
