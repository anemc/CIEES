using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIEES.Dal
{
    public class MyDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            context.Users.Add(new Models.Users() { Nombre = "Diana", ApellidoP = "Montejo", ApellidoM = "Arroyo", Usuario = "anemce", Contrasena = "123456", Correo = "diana@uv.com", Tipo = "admin" });
            /*context.Tables.Add(new Models.Tables() { Nombre = "T111" });
            context.Tables.Add(new Models.Tables() { Nombre = "T112" });
            context.Tables.Add(new Models.Tables() { Nombre = "T113" });
            context.Tables.Add(new Models.Tables() { Nombre = "T114" });
            context.Tables.Add(new Models.Tables() { Nombre = "T115" });
            context.Tables.Add(new Models.Tables() { Nombre = "T121" });
            context.Tables.Add(new Models.Tables() { Nombre = "T122" });
            context.Tables.Add(new Models.Tables() { Nombre = "T123" });
            context.Tables.Add(new Models.Tables() { Nombre = "T124" });
            context.Tables.Add(new Models.Tables() { Nombre = "T125" });
            context.Tables.Add(new Models.Tables() { Nombre = "T126" });
            context.Tables.Add(new Models.Tables() { Nombre = "T127" });
            context.Tables.Add(new Models.Tables() { Nombre = "T231" });
            context.Tables.Add(new Models.Tables() { Nombre = "T232" });
            context.Tables.Add(new Models.Tables() { Nombre = "T233" });
            context.Tables.Add(new Models.Tables() { Nombre = "T234" });
            context.Tables.Add(new Models.Tables() { Nombre = "T235" });
            context.Tables.Add(new Models.Tables() { Nombre = "T241" });
            context.Tables.Add(new Models.Tables() { Nombre = "T242" });
            context.Tables.Add(new Models.Tables() { Nombre = "T243" });
            context.Tables.Add(new Models.Tables() { Nombre = "T351" });
            context.Tables.Add(new Models.Tables() { Nombre = "T352" });
            context.Tables.Add(new Models.Tables() { Nombre = "T353" });
            context.Tables.Add(new Models.Tables() { Nombre = "T354" });
            context.Tables.Add(new Models.Tables() { Nombre = "T361" });
            context.Tables.Add(new Models.Tables() { Nombre = "T362" });
            context.Tables.Add(new Models.Tables() { Nombre = "T363" });
            context.Tables.Add(new Models.Tables() { Nombre = "T364" });
            context.Tables.Add(new Models.Tables() { Nombre = "T365" });
            context.Tables.Add(new Models.Tables() { Nombre = "T371" });
            context.Tables.Add(new Models.Tables() { Nombre = "T372" });
            context.Tables.Add(new Models.Tables() { Nombre = "T373" });
            context.Tables.Add(new Models.Tables() { Nombre = "T374" });
            context.Tables.Add(new Models.Tables() { Nombre = "T375" });
            context.Tables.Add(new Models.Tables() { Nombre = "T381" });
            context.Tables.Add(new Models.Tables() { Nombre = "T382" });
            context.Tables.Add(new Models.Tables() { Nombre = "T383" });
            context.Tables.Add(new Models.Tables() { Nombre = "T384" });
            context.Tables.Add(new Models.Tables() { Nombre = "T385" });
            context.Tables.Add(new Models.Tables() { Nombre = "T386" });
            context.Tables.Add(new Models.Tables() { Nombre = "T491" });
            context.Tables.Add(new Models.Tables() { Nombre = "T492" });
            context.Tables.Add(new Models.Tables() { Nombre = "T493" });
            context.Tables.Add(new Models.Tables() { Nombre = "T494" });
            context.Tables.Add(new Models.Tables() { Nombre = "T495" });
            context.Tables.Add(new Models.Tables() { Nombre = "T496" });
            context.Tables.Add(new Models.Tables() { Nombre = "T497" });
            context.Tables.Add(new Models.Tables() { Nombre = "T498" });
            context.Tables.Add(new Models.Tables() { Nombre = "T499" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4101" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4102" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4103" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4104" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4105" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4106" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4111" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4112" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4113" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4114" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4115" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4116" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4121" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4122" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4122" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4123" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4124" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4125" });
            context.Tables.Add(new Models.Tables() { Nombre = "T4126" });*/
            context.T111.Add(new Models.T111() { F_Mod = DateTime.Now });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}