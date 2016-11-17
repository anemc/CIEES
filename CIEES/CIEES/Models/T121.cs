using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T121")]
    public class T121
    {
        [Key]
        public int T121Id { get; set; }
        public string Nombre { get; set; }
        public string Registro { get; set; }
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}