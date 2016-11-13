using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T112")]
    public class T112
    {
        [Key]
        public int T112Id { get; set; }
        public string Fundamentos { get; set; }
        public string Cobertura { get; set; }
        public string Pertenencia { get; set; }
        public string Perfil { get; set; }
        public int IdUsuario { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}