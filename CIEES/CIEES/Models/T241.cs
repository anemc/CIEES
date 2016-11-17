using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T241")]
    public class T241
    {
        [Key]
        public int T241Id { get; set; }
        public string Actividades { get; set; }
        public string Valoracion { get; set; }
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}