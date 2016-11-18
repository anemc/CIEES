using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T493")]
    public class T493
    {
        [Key]
        public int T493ID { get; set; }
        public int UsuarioId { get; set; }
        public string Superacion { get; set; }
        public string Procedimiento { get; set; }
        public string Profesor1 { get; set; }    // sin contador 
        public string Profesor2 { get; set; }   //sin contador 
        public string Resultador { get; set; }   
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}