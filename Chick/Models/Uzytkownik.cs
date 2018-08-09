using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("Uzytkownicy")]
    public class Uzytkownik
    {
        [Key]
        public int ID { get; set; }

        public int Typ { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Column(TypeName = "VARCHAR(MAX)")]
        public string Email { get; set; }

        [DefaultValue(true)]
        public bool Newsletter { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(MAX)")]
        public string LinkDoPolecenia { get; set; }

        [DataType(DataType.Password)]
        [Column(TypeName = "VARCHAR(MAX)")]
        public string Haslo { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Imie { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Nazwisko { get; set; }

        public int? Plec { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        [Column(TypeName = "VARCHAR(MAX)")]
        public string NrTelefonu { get; set; }

        public int? Dietetyk { get; set; }

        [DefaultValue(false)]
        public bool Usuniety { get; set; }

        public DateTime DataDodania { get; set; } = DateTime.Now;

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("Dietetyk")]
        public virtual ICollection<Uzytkownik> Dietetycy { get; set; }

        [ForeignKey("Dietetyk")]
        public virtual ICollection<Pacjent> Pacjenci { get; set; }

        [ForeignKey("Uzytkownik")]
        public virtual ICollection<Danie> DaniaUzytkownika { get; set; }

        [ForeignKey("Uzytkownik")]
        public virtual ICollection<Skladnik> SkladnikiUzytkownika { get; set; }
    }
}