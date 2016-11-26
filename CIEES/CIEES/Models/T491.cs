using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T491")]
    public class T481
    {
        [Key]
        public int T481Id { get; set; }
        public string Total_Prof { get; set; }  // sin contador
        public string Descrip1 { get; set; }
        public string Descrip2 { get; set; }
        public string Funciones { get; set; }
        public string Valor { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}