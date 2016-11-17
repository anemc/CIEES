using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T351")]
    public class T351
    {
        [Key]
        public int T351Id { get; set; }
        public string Estrategias { get; set; }
        public string Val1 { get; set; }
        public string Val2 { get; set; }
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}