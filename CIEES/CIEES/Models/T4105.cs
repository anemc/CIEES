using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4105")]
    public class T4105
    {
        [Key]
        public int T4105Id { get; set; }
        public string Espacios { get; set; }
        public string Profesores { get; set; }    //sin contador
        public string Valor1 { get; set; }    
        public string Valor2 { get; set; }  
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}