﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CIEES.Models
{
    [Table("T4111")]
    public class T4111
    {
        [Key]
        public int T4111Id { get; set; }
        public string Caract { get; set; }
        public string Condiciones { get; set; }
       
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        public DateTime F_Lim { get; set; }
        public DateTime F_Mod { get; set; }
    }
}