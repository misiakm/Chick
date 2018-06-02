using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("Pacjenci")]
    public class Pacjent
    {
        [Key]
        public int ID { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public string Opis { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string NrTelefonu { get; set; }

        [DefaultValue(1)]
        public int Status { get; set; }

        public int? Dietetyk { get; set; }

        [DefaultValue(170)]
        public int? Wzrost { get; set; }

        public int? Plec { get; set; }

        [DefaultValue(false)]
        public bool Usuniety { get; set; }

        public DateTime DataDodania { get; set; } = DateTime.Now;

        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("Pacjent")]
        public virtual ICollection<Dieta> Diety { get; set; }

        [ForeignKey("Pacjent")]
        public virtual ICollection<Pomiar> Pomiary { get; set; }
    }
}