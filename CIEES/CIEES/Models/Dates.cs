using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("Dates")]
    public class Dates
    {
        [Key]
        public int FechaId { get; set; }
        [Display(Name = "Inicio de Semestre")]
        public DateTime Ini_Sem { get; set; }
        [Display(Name = "Final de Semestre")]
        public DateTime Fin_Sem { get; set; }
        public int Aler_Sem { get; set; }
        public int Aler_Lim { get; set; }
    }
}