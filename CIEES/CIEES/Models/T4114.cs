using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4114")]
    public class T4114
    {
        [Key]
        public int T4114Id { get; set; }
        public string Protocolos { get; set; }
        public string Acciones { get; set; }
        public string Medios { get; set; }
        public string Ambiente { get; set;}
        public string Salud { get; set; }
        public string Proteccion { get; set; }
        public string Integridad { get; set; }
        public string Condiciones { get; set; }

        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}