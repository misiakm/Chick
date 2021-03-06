﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("TypyWpisow")]
    public class TypWpisu
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(MAX)")]
        public string Typ { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("TypWpisu")]
        public virtual ICollection<DanieJadlospisu> DaniaJadlospisu { get; set; }
    }
}