using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("PrzeznaczeniaDan")]
    public class PrzeznaczenieDania
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int Danie { get; set; }

        [Required]
        public int Posilek { get; set; }
    }
}