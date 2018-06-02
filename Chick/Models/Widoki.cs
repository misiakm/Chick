namespace Chick.Models
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
