using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T383")]
    public class T383
    {
        [Key]
        public int T383Id { get; set; }
        public string Eventos { get; set; }
        public string Politica { get; set; }
        public string Valoracion { get; set; }
        public string Obstaculos { get; set; }
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}