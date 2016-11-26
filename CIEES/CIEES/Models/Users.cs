using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        public string ApellidoP { get; set; }
        [Display(Name = "Apellido Materno")]
        public string ApellidoM { get; set; }
        public string Usuario { get; set; }
        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; }
        public string Tipo { get; set; }
    }
}