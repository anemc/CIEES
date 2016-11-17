using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T111")]
    public class T111
    {
        [Key]
        public int T111Id { get; set; }
        public string Mision { get; set; }      //sin contador
        public string Vision { get; set; }      //sin contador
        public string Objetivos { get; set; }   //sin contador
        public DateTime F_Aprob { get; set; }   //sin contador
        public string Resp1 { get; set; }
        public string Resp2 { get; set; }
        public string Resp3 { get; set; }
        public string Resp4 { get; set; }
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime f_Mod { get; set; }

    }
}