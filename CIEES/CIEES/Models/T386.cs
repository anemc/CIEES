using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T386")]
    public class T386
    {
        [Key]
        public int T386Id { get; set; }
        public string Cumplimiento { get; set; }
        public string Valoracion { get; set; }
        public string Fortalezas { get; set; }  //sin contador
        public string Mejoras { get; set; }     //sin contador
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}