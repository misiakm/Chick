using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("Plcie")]
    public class Plec
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string NazwaPlci { get; set; }

        [ForeignKey("Plec")]
        public virtual ICollection<Pacjent> Pacjenci { get; set; }

        [ForeignKey("Plec")]
        public virtual ICollection<Uzytkownik> Uzytkownicy { get; set; }
    }
}