using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4116")]
    public class T4116
    {
        [Key]
        public int T4116Id { get; set; }
        public string Servicios { get; set; }
        public string Software { get; set; }   //sin contador
        public string Procedimientos { get; set; }
        public string Servicios { get; set; }
        public string Capacidad { get; set; }
        public string Fortalezas { get; set; }
        public string Mejora { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}