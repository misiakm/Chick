namespace Chick.Models.Widoki
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SumyDan")]
    public partial class SumyDan
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Nazwa { get; set; }

        public int? Waga { get; set; }

        public int? Kalorycznosc { get; set; }

        public decimal? Bialko { get; set; }

        public decimal? Tluszcz { get; set; }

        public decimal? Weglowodany { get; set; }

        public int? Uzytkownik { get; set; }

        public string Klucz { get; set; }
    }
}
