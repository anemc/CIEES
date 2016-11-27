using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T493")]
    public class T493
    {
        [Key]
        public int T493Id { get; set; }
        public string Superacion { get; set; }
        public string Procedimiento { get; set; }
        public string Profesor1 { get; set; }    //sin contador 
        public string Profesor2 { get; set; }   //sin contador 
        public string Resultador { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}