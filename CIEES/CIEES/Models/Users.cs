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
        [Display(Name = "Contraseña"), DataType(DataType.Password)]
        public string Contrasena { get; set; }
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3]\.)|(([\w-]+\.)+))([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter valid email.")]
        public string Correo { get; set; }
        public string Tipo { get; set; }
    }
}