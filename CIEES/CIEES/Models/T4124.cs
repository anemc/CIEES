using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4124")]
    public class T4124
    {
        [Key]
        public int T4124Id { get; set; }
        public string Acciones { get; set; }
        public string Procedimiento { get; set; }
        public string Estudio { get; set; }
        public string Resultados { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}