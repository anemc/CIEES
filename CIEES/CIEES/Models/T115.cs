using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T115")]
    public class T115
    {
        [Key]
        public int T115Id { get; set; }
        public string Aspecto { get; set; }
        public string Pertenencia { get; set; }
        public string Fortalezas { get; set; }  //sin contador
        public string Mejoras { get; set; }     //sin contador
        public int IdUsuario { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}