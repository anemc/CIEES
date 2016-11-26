using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("Tables")]
    public class Tables
    {
        [Key]
        public int TablaId { get; set; }
        public string Nombre { get; set; }
    }
}