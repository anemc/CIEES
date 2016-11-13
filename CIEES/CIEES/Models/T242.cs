using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T242")]
    public class T242
    {
        [Key]
        public int T242Id { get; set; }
        public string Lengua_nivel { get; set; }
        public string Lengua_Otras { get; set; }
        public string Lengua_Apoyo { get; set; }
        public string Lengua_Pertenen { get; set; }
        public string Suficiencia { get; set; }
        public int IdUsuario { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}