﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("Posilki")]
    public class Posilek
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(MAX)")]
        public string NazwaPosilku { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("Posilek")]
        public virtual ICollection<PlanDnia> PlanyDnia { get; set; }

        [ForeignKey("Posilek")]
        public virtual ICollection<PrzeznaczenieDania> PrzeznaczoneDania { get; set; }
    }
}