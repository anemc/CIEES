using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T382")]
    public class T382
    {
        [Key]
        public int T382Id { get; set; }
        public string Resul_Esperado { get; set; }
        public string Resul_Obtenido { get; set; }
        public string Certificaciones { get; set; }
        public string Valoracion { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}