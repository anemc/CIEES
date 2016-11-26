using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T365")]
    public class T365
    {
        [Key]
        public int T365Id { get; set; }
        public string Requerimentos { get; set; }   //sin contador
        public string Practicas { get; set; }
        public string Valoracion { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}