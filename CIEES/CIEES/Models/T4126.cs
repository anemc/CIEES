using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4126")]
    public class T4126
    {
        [Key]
        public int T4126Id { get; set; }
        public string Espacios { get; set; }
        public string Apoyo { get; set; }
        public string  Satisf { get; set; }
        public string Campaña { get; set; }
        public string Servicios { get; set; }
        public string Fortalezas { get; set; }
        public string Mejora { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}