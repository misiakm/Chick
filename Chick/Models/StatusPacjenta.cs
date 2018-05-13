using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("StatusyPacjentow")]
    public class StatusPacjenta
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Status { get; set; }

        [ForeignKey("Status")]
        public virtual ICollection<Pacjent> Pacjenci { get; set; }
    }
}