using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T362")]
    public class T362
    {
        [Key]
        public int T362Id { get; set; }
        public string Procedimiento { get; set; }
        public string Lista_Inst { get; set; }  //sin contador
        public string Valoracion { get; set; }  //sin contaddor
        public string Obstaculos { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}