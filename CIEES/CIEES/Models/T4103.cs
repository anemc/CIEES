using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4103")]
    public class T4103
    {
        [Key]
        public int T4103Id { get; set; }
        public string Asignaturas { get; set; }   //sin contador
        public string Instalaciones { get; set; }  //sin contador
        public string Convenios { get; set; }    
        public string Apoyos { get; set; }   
        public string Manuales { get; set; }
        public string Valoracion { get; set; }
        public string Obstaculos  { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}