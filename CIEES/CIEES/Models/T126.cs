using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T126")]
    public class T126
    {
        [Key]
        public int T126Id { get; set; }
        public string Ideario { get; set; }
        public string Estrategia_Imp { get; set; }
        public string Mecanismo { get; set; }
        public string Estrategia_Usada { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}