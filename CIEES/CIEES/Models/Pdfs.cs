using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("Pdfs")]
    public class Pdfs
    {
        [Key]
        public int PdfId { get; set; }
        public string Nombre { get; set; }
        public string Ruta { get; set; }
        public string TablaId { get; set; }
        public DateTime F_Mod { get; set; }
    }
}