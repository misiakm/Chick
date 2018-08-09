using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("TypyUzytkownikow")]
    public class TypUzytkownika
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Typ { get; set; }

        [DefaultValue(false)]
        public bool Usuniety { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("Typ")]
        public virtual ICollection<Uzytkownik> Uzytkownicy { get; set; }
    }
}