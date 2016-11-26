using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T113")]
    public class T113
    {
        [Key]
        public int T113Id { get; set; }
        public string Aspecto { get; set; }
        public string Acciones { get; set; }
        public string Grado { get; set; }
        public string Ejecucion { get; set; }
        public string Aspectos { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}