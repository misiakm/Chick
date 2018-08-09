using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("Dania")]
    public class Danie
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(MAX)")]
        public string Nazwa { get; set; }

        [Required]
        [DefaultValue(100)]
        public decimal WagaPorcji { get; set; }

        public int? Uzytkownik { get; set; }

        public int? Kategoria { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("Danie")]
        public virtual ICollection<PrzeznaczenieDania> PrzeznaczonePosilki { get; set; }
    }
}