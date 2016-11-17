using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T374")]
    public class T374
    {
        [Key]
        public int T374Id { get; set; }
        public string Requisitos { get; set; }
        public string Evaluacion { get; set; }
        public string Valoracion { get; set; }
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}