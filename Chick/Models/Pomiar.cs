using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("Pomiary")]
    public class Pomiar
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int Pacjent { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public decimal? Masa { get; set; }

        public decimal? ObwodTalii { get; set; }

        public decimal? ObwodBioder { get; set; }

        public decimal? ObwodKlatkiPiersiowej { get; set; }

        public decimal? ObwodRamienia { get; set; }

        public decimal? ObwodLydki { get; set; }

        public decimal? ObwodUda { get; set; }

        public int PoziomAktywnosciFizycznej { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [DefaultValue(false)]
        [Required]
        public bool Usuniety { get; set; }
    }
}