using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("RecepturyJadlospisu")]
    public class RecepturaJadlospisu
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int Skladnik { get; set; }

        [Required]
        [DefaultValue(100)]
        public int Waga { get; set; }

        [Required]
        public int DanieJadlospisu { get; set; }
    }
}