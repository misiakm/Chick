using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("PoziomyAktywnosci")]
    public class PoziomAktywnosci
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string NazwaAktywnosci { get; set; }

        [Required]
        public decimal Wspolczynnik { get; set; }

        [ForeignKey("PoziomAktywnosciFizycznej")]
        public virtual ICollection<Pomiar> Pomiary { get; set; }
    }
}