using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T354")]
    public class T354
    {
        [Key]
        public int T354Id { get; set; }
        public string Acciones { get; set; }
        public string Fortalezas { get; set; }  //sin contador
        public string Mejoras { get; set; }     //sin contador
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}