using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T352")]
    public class T352
    {
        [Key]
        public int T352Id { get; set; }
        public string Procedimiento { get; set; }
        public string Tabla_Asp { get; set; }       //archivo
        public string Ingreso { get; set; }
        public string Val1 { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}