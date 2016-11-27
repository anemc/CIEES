using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4102")]
    public class T4102
    {
        [Key]
        public int T4102Id { get; set; }
        public string Asignaturas { get; set; }    //sin contador
        public string Espacios { get; set; }       //sin contador
        public string Caracteristicas { get; set; }    //sin contador 
        public string Manuales { get; set; }   //sin contador 
        public string Valor1 { get; set; }
        public string Valor2 { get; set; }
        public string Valor3 { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}