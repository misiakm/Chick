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
        public string NazwaDania { get; set; }

        [Required]
        [DefaultValue(100)]
        public int Waga { get; set; }

        [Required]
        [DefaultValue(0)]
        public int TypWpisu { get; set; }

        public string Opis { get; set; }

        [ForeignKey("DanieJadlospisu")]
        public virtual ICollection<PlanDnia> PlanyDni { get; set; }

        [ForeignKey("DanieJadlospisu")]
        public virtual ICollection<RecepturaJadlospisu> Receptura { get; set; }

    }
}