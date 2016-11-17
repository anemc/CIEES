using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T123")]
    public class T123
    {
        [Key]
        public int T123Id { get; set; }
        public string Alum_Ins { get; set; }    //archivo
        public string Alum_Ciclo { get; set; }  //archivo
        public string Evolucion { get; set; }
        public string Evolucion_Tot { get; set; }
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}