using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T124")]
    public class T124
    {
        [Key]
        public int T124Id { get; set; }
        public string Presupuesto { get; set; }
        public string Fuentes_Ad { get; set; }
        public string Recursos { get; set; }
        public string Falta_Rec { get; set; }
        public string Insuficiencia { get; set; }
        public int IdUsuario { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}