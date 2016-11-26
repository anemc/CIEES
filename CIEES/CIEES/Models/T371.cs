using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T371")]
    public class T371
    {
        [Key]
        public int T371Id { get; set; }
        public string Requisitos { get; set; }
        public string Tabla_Titulos { get; set; }   //archivo
        public string Valoracion { get; set; }
        public string Docentes { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}