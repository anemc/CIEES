using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T125")]
    public class T125
    {
        [Key]
        public int T125Id { get; set; }
        public string Estructura_Org { get; set; }
        public string Lista_Per { get; set; }       //archivo
        public string Estructura_Vig { get; set; }
        public string Lista_Areas { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}