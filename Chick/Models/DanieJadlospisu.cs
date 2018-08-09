using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("DaniaJadlospisu")]
    public class DanieJadlospisu
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(MAX)")]
        public string NazwaDania { get; set; }

        [Required]
        [DefaultValue(0)]
        public int TypWpisu { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Opis { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Klucz { get; set; } = WD.WspolneDane.GenerujKlucz();

        [ForeignKey("DanieJadlospisu")]
        public virtual ICollection<PlanDnia> PlanyDni { get; set; }

        [ForeignKey("DanieJadlospisu")]
        public virtual ICollection<RecepturaJadlospisu> Receptura { get; set; }

    }
}