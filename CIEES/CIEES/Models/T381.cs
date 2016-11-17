using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T381")]
    public class T381
    {
        [Key]
        public int T381Id { get; set; }
        public string Examenes { get; set; }    //sin contador
        public string Resultados { get; set; }  //archivo
        public string Valoracion { get; set; }  //sin contador
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}