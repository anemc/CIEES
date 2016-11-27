using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4113")]
    public class T4113
    {
        [Key]
        public int T4113Id { get; set; }
        public string Programa { get; set; }
        public string Procedimiento { get; set; }
        public string Condiciones { get; set; }    
        
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}