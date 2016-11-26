using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T233")]
    public class T233
    {
        [Key]
        public int T233Id { get; set; }
        public string Curricula { get; set; }       //sin contador
        public string Asignaturas { get; set; }     //sin contador
        public string Curricula_Mej { get; set; }   //sin contador
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}