using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T375")]
    public class T375
    {
        [Key]
        public int T375Id { get; set; }
        public string Contacto { get; set; }
        public string Actividades { get; set; }
        public string Valoracion { get; set; }
        public string Fortalezas { get; set; }
        public string Mejoras { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}