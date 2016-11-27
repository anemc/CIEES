using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4115")]
    public class T4115
    {
        [Key]
        public int T4115Id { get; set; }
        public string Areas1 { get; set; }
        public string Areas2 { get; set; }
        public string Areas3 { get; set; }
        public string Protocolos { get; set; }
        public string Condiciones { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}