using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T122")]
    public class T122
    {
        [Key]
        public int T122Id { get; set; }
        public string Documentos { get; set; }  //sin contador
        public string Pertenencia { get; set; }
        public string Normativo { get; set; }
        public int IdUsuario { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}