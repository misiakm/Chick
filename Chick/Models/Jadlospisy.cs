namespace Chick.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Jadlospisy")]
    public partial class Jadlospisy
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDDni { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDTygodnie { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDDiety { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPacjent { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Data { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kalorycznosc { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime DataPoczatkowa { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime DataKoncowa { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public string KluczDiety { get; set; }

        public string Opis { get; set; }

        public DateTime? OstatniUlozonyDzien { get; set; }
    }
}
