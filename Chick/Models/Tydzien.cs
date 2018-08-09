using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("Tygodnie")]
    public class Tydzien
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int NrTygodnia { get; set; }

        [Required]
        public int Dieta { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Kalorycznosc { get; set; }

        [DefaultValue(0.25)]
        public decimal Bialko { get; set; }

        [DefaultValue(0.25)]
        public decimal Tluszcz { get; set; }

        [DefaultValue(0.50)]
        public decimal Weglowodany { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("Tydzien")]
        public virtual ICollection<Dzien> Dni { get; set; }
    }
}