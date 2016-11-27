using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T495")]
    public class T495
    {
        [Key]
        public int T495Id { get; set; }
        public string Evaluacion { get; set; }
        public string Reconocimiento { get; set; }
        public string Valoracion { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}