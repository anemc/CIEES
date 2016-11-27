﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T493")]
    public class T493
    {
        [Key]
        public int T493ID { get; set; }
        public string Programa { get; set; }
        public string Procedimiento { get; set; }
        public string Condiciones { get; set; }    
        
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}