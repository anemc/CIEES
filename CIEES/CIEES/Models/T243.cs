using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T243")]
    public class T243
    {
        [Key]
        public int T243Id { get; set; }
        public string Certificacion { get; set; }
        public string Certificacion_Apoyo { get; set; }
        public string Certificacion_Resul { get; set; }
        public string Fortalezas { get; set; }      //sin contador
        public string Mejoras { get; set; }         //sin contador
        public int IdUsuario { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}