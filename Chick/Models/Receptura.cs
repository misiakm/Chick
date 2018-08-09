using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("Receptura")]
    public class Receptura
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int Skladnik { get; set; }

        [Required]
        public int Danie { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Opis { get; set; }

        [Required]
        [DefaultValue(100)]
        public int Waga { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();
    }
}