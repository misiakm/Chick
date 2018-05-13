using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chick.Models
{
    [Table("TypyUzytkownikow")]
    public class TypUzytkownika
    {
        [Key]
        public int ID { get; set; }

        public string Typ { get; set; }

        [DefaultValue(false)]
        public bool Usuniety { get; set; }

        [ForeignKey("Typ")]
        public virtual ICollection<Uzytkownik> Uzytkownicy { get; set; }
    }
}