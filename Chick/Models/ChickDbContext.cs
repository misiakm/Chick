namespace Chick.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ChickDbContext : DbContext
    {
        public ChickDbContext()
            : base("name=ChickDbContext")
        {
        }

        public DbSet<Danie> Dania { get; set; }
        public DbSet<Dieta> Diety { get; set; }
        public DbSet<DanieJadlospisu> DaniaJadlospisu { get; set; }
        public DbSet<Dzien> Dni { get; set; }
        public DbSet<KategoriaDania> KategorieDan { get; set; }
        public DbSet<KategoriaSkladnika> KategorieSkladnikow { get; set; }
        public DbSet<Pacjent> Pacjenci { get; set; }
        public DbSet<PlanDnia> PlanyDni { get; set; }
        public DbSet<Plec> Plcie { get; set; }
        public DbSet<Pomiar> Pomiary { get; set; }
        public DbSet<Posilek> Posilki { get; set; }
        public DbSet<PoziomAktywnosci> PoziomyAktywnosci { get; set; }
        public DbSet<PrzeznaczenieDania> PrzeznaczeniaDan { get; set; }
        public DbSet<Receptura> Receptury { get; set; }
        public DbSet<RecepturaJadlospisu> RecepturyJadlospisu { get; set; }
        public DbSet<Skladnik> Skladniki { get; set; }
        public DbSet<SkladnikJadlospisu> SkladnikiJadlospisu { get; set; }
        public DbSet<StatusPacjenta> StatusyPacjentow { get; set; }
        public DbSet<Tydzien> Tygodnie { get; set; }
        public DbSet<TypUzytkownika> TypyUzytkownikow { get; set; }
        public DbSet<TypWpisu> TypyWpisow { get; set; }
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
