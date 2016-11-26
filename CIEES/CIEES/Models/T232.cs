using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T232")]
    public class T232
    {
        [Key]
        public int T232Id { get; set; }
        public string Fundamentacion { get; set; }
        public string Procedimiento { get; set; }
        public string Congruencia { get; set; }
        public string Cambios { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}