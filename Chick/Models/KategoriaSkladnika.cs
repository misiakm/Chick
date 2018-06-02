using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("KategorieSkladnikow")]
    public class KategoriaSkladnika
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string NazwaKategorii { get; set; }

        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("Kategoria")]
        public virtual ICollection<Skladnik> Skladniki { get; set; }
    }
}