using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("Diety")]
    public class Dieta
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public DateTime DataPoczatkowa { get; set; }

        [Required]
        public DateTime DataKoncowa { get; set; }

        public int IloscTygodni { get; set; }

        [Required]
        public int Pacjent { get; set; }

        public string Opis { get; set; }

        public string Wykluczenia { get; set; }

        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("Dieta")]
        public virtual ICollection<Tydzien> Tygodnie { get; set; }
    }
}