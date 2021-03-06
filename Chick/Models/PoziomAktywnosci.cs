﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("PoziomyAktywnosci")]
    public class PoziomAktywnosci
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(MAX)")]
        public string NazwaAktywnosci { get; set; }

        [Required]
        public decimal Wspolczynnik { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("PoziomAktywnosciFizycznej")]
        public virtual ICollection<Pomiar> Pomiary { get; set; }
    }
}