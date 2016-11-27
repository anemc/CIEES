using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4104")]
    public class T4104
    {
        [Key]
        public int T4104Id { get; set; }
        public string Caract { get; set; }
        public string Bibliografia { get; set; }     //sin contador
        public string Acervos { get; set; }    
        public string Acervos2 { get; set; }   
        public string Proced1 { get; set; }
        public string Proced2 { get; set; }
        public string Servicios { get; set; }
        public string Convenios { get; set; }     //sin contador
        public string Valor1 { get; set; }
        public string Valor2 { get; set; }
        public string Valor3 { get; set; }
        public string Valor4 { get; set; }
        public string Valor5 { get; set; }
        public string Valor6 { get; set; }
        public string Valor7 { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}