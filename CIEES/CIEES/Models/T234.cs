using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T234")]
    public class T234
    {
        [Key]
        public int T234Id { get; set; }
        public string Proced_Prop { get; set; }
        public string Proced_Eval { get; set; }
        public string Asignatura { get; set; }
        public string Resul_Alc { get; set; }
        public int IdUsuario { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}