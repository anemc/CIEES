using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T114")]
    public class T114
    {
        [Key]
        public int T114Id { get; set; }
        public string Aspectos { get; set; }    //sin contador
        public string Coincidencias { get; set; }
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}