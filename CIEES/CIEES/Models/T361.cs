using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T361")]
    public class T361
    {
        [Key]
        public int T361Id { get; set; }
        public string Abandono { get; set; }    //archivo
        public string Rezago { get; set; }      //archivo
        public string Asignaturas { get; set; }
        public string Justificacion { get; set; }
        public string Solucion { get; set; }
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}