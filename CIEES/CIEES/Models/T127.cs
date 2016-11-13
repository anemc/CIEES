using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T127")]
    public class T127
    {
        [Key]
        public int T124Id { get; set; }
        public string Ambiente_Area { get; set; }
        public string Ambiente_Pers { get; set; }
        public string Organizacion { get; set; }
        public string Ambiente { get; set; }
        public string Fortalezas { get; set; }
        public string Mejoras { get; set; }
        public int IdUsuario { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}