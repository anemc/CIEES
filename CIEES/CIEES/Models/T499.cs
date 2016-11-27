using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T499")]
    public class T499
    {
        [Key]
        public int T499Id { get; set; }
        public string Posgrado { get; set; }      //sin contador
        public string Nombre { get; set; }       //sin contador
        public string Investigacion { get; set; }     
        public string Valoracion { get; set; }   //sin contador 
        public string Fortalezas { get; set; }   //sin contador 
        public string Mejoras { get; set; }
        [Display(Name = "Usuario")]              // sin contador
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}