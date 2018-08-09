namespace Chick.Models.Widoki
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Widoki : DbContext
    {
        public Widoki()
            : base("name=ChickDbContext")
        {
        }

        public virtual DbSet<Jadlospisy> Jadlospisy { get; set; }
        public virtual DbSet<DaniaWPosilku> DaniaWPosilku { get; set; }
        public virtual DbSet<SumyDan> SumyDan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DaniaWPosilku>()
                .Property(e => e.Bialka)
                .HasPrecision(38, 2);

            modelBuilder.Entity<DaniaWPosilku>()
                .Property(e => e.Weglowodany)
                .HasPrecision(38, 2);

            modelBuilder.Entity<DaniaWPosilku>()
                .Property(e => e.Tluszcze)
                .HasPrecision(38, 2);

            modelBuilder.Entity<SumyDan>()
                .Property(e => e.Bialko)
                .HasPrecision(38, 2);

            modelBuilder.Entity<SumyDan>()
                .Property(e => e.Tluszcz)
                .HasPrecision(38, 2);

            modelBuilder.Entity<SumyDan>()
                .Property(e => e.Weglowodany)
                .HasPrecision(38, 2);
        }
    }
}
