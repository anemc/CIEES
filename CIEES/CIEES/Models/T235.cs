using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T235")]
    public class T235
    {
        [Key]
        public int T235Id { get; set; }
        public string Tecnologia { get; set; }
        public string Resultados { get; set; }
        public string Elemento { get; set; }
        public string Efectividad { get; set; }
        public string Suficiencia_Inf { get; set; }
        public string Suficiencia_Prof { get; set; }
        public string Fortalezas { get; set; }
        public string Mejoras { get; set; }
        public int IdUsuario { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}