using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T373")]
    public class T373
    {
        [Key]
        public int T373Id { get; set; }
        public string Tabla_Eficiencia { get; set; }    //archivo
        public string Justificacion { get; set; }
        public string Valoracion { get; set; }
        public string Valoracion2 { get; set; }
        public string Valoracion3 { get; set; }
        public string Acciones { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}