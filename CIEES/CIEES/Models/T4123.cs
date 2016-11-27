using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4123")]
    public class T4123
    {
        [Key]
        public int T4123Id { get; set; }
        public string Becas { get; set; }   //sin contador
        public string Normativa { get; set; }   //sin contador 
        public string Apoyo { get; set; }
        public string Resultados { get; set; }
        public string Suficiencia { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}