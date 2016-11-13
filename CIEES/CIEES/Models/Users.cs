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
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Tipo { get; set; }
    }
}