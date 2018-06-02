using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("PlanyDni")]
    public class PlanDnia
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int Dzien { get; set; }

        [Required]
        public int DanieJadlospisu { get; set; }

        [Required]
        public int Posilek { get; set; }

        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();
    }
}