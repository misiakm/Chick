﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("KategorieDan")]
    public class KategoriaDania
    {
        [Key]
        public int ID { get; set; }

        public string NazwaKategorii { get; set; }

        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("Kategoria")]
        public virtual ICollection<Danie> Dania { get; set; }
    }
}