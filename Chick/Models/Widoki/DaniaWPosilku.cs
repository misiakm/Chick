namespace Chick.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DaniaWPosilku")]
    public partial class DaniaWPosilku
    {
        public int? ID { get; set; }

        public DateTime? Godzina { get; set; }

        public string NazwaDania { get; set; }

        public int? Waga { get; set; }

        public int? Kalorycznosc { get; set; }

        public decimal? Bialka { get; set; }

        public decimal? Weglowodany { get; set; }

        public decimal? Tluszcze { get; set; }

        public string KluczDania { get; set; }

        public string KluczDiety { get; set; }

        public string KluczDnia { get; set; }

        public DateTime? Data { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Posilek { get; set; }

        [Key]
        [Column(Order = 1)]
        public string NazwaPosilku { get; set; }

        [Key]
        [Column(Order = 2)]
        public int UserID { get; set; }
    }
}
