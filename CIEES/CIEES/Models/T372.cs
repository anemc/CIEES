using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T372")]
    public class T372
    {
        [Key]
        public int T372Id { get; set; }
        public string Tabla_Eficiencia { get; set; }        //archivo
        public string Justificacion { get; set; }           //sin contador
        public string Valoracion { get; set; }
        public string Valoracion2 { get; set; }
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }
    }
}