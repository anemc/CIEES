using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T364")]
    public class T364
    {
        [Key]
        public int T364Id { get; set; }
        public string Asesorias { get; set; }
        public string Lista { get; set; }       //sin contador
        public string Impacto { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}