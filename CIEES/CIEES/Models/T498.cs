using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T498")]
    public class T498
    {
        [Key]
        public int T498Id { get; set; }
        public string Programa { get; set; }
        public string Academicos { get; set; }   //sin contador
        public string Relacion { get; set; }     
        public string Investigacion { get; set; }  
        
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}