using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIEES.Dal
{
    public class MyDbInitializer : System.Data.Entity.CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            //context.Usuarios.Add(new Usuarios() { Usuario = "anemc", Contrasena = "12345" });
            //context.SaveChanges();
            //base.Seed(context);
        }
    }
}