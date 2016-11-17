using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T231")]
    public class T231
    {
        [Key]
        public int T231Id { get; set; }
        public string Modelo_Edu { get; set; }
        public string Modelo_Apl { get; set; }
        public string Modelo_Compat { get; set; }
        public string Modelo_Doc { get; set; }
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}