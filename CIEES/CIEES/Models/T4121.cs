using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4121")]
    public class T4121
    {
        [Key]
        public int T4121Id { get; set; }
        public string Funciones { get; set; }
        public string Tramites { get; set; }  //sin contador 
        public string Procedimiento { get; set; }
        public string Estadisticas { get; set; }  //sin contador
        public string Certi { get; set;  }        //sin contador 
        public string Valor1 { get; set; }
        public string Valor2 { get; set; }
        public string Valor3 { get; set; }
        public string Valor4 { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}