using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4106")]
    public class T4106
    {
        [Key]
        public int T4106Id { get; set; }
        public string Espacios { get; set; }
        public string Procedimiento { get; set; }
        public string Valoracion { get; set; }    
        public string Fortalezas { get; set; }    //sin contador 
        public string Mejoras { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}