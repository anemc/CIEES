using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T363")]
    public class T363
    {
        [Key]
        public int T363Id { get; set; }
        public string Proc_Tutorias { get; set; }
        public string Perfil { get; set; }
        public string Tutores { get; set; }     //archivo
        public string Impacto { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}