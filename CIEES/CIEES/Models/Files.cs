using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("Files")]
    public class Files
    {
        [Key]
        public int ArchivoId { get; set; }
        public string Nombre { get; set; }
        public string Ruta { get; set; }
        public string IdTabla { get; set; }
        public DateTime F_Mod { get; set; }
    }
}