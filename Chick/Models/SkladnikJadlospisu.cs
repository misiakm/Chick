using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("SkladnikiJadlospisu")]
    public class SkladnikJadlospisu
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string NazwaSkladnika { get; set; }

        [Required]
        [DefaultValue(0)]
        public int Kalorycznosc { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal Bialko { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal Tluszcz { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal Weglowodanych { get; set; }

        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("Skladnik")]
        public virtual ICollection<RecepturaJadlospisu> Receptury { get; set; }
    }
}