using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T494")]
    public class T494
    {
        [Key]
        public int T494Id { get; set; }
        public string Procedimiento { get; set; }
        public string Convenios { get; set; }
        public string Valor { get; set; }
        public string Obstaculos { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}