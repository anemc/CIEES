using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4101")]
    public class T4101
    {
        [Key]
        public int T4101ID { get; set; }
        public string Aulas { get; set; }     //sin contador
        public string Caracteristicas { get; set; }
        public string Condiciones { get; set; }     
        public string Suficiencia { get; set; }    
        public string Mobiliario { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}}