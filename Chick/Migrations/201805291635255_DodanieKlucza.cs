namespace Chick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanieKlucza : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dania", "Klucz", c => c.String());
            AddColumn("dbo.PrzeznaczeniaDan", "Klucz", c => c.String());
            AddColumn("dbo.DaniaJadlospisu", "Klucz", c => c.String());
            AddColumn("dbo.PlanyDni", "Klucz", c => c.String());
            AddColumn("dbo.RecepturyJadlospisu", "Klucz", c => c.String());
            AddColumn("dbo.Dni", "Klucz", c => c.String());
            AddColumn("dbo.KategorieDan", "Klucz", c => c.String());
            AddColumn("dbo.KategorieSkladnikow", "Klucz", c => c.String());
            AddColumn("dbo.Skladniki", "Klucz", c => c.String());
            AddColumn("dbo.Receptura", "Klucz", c => c.String());
            AddColumn("dbo.Pacjenci", "Klucz", c => c.String());
            AddColumn("dbo.Diety", "Klucz", c => c.String());
            AddColumn("dbo.Tygodnie", "Klucz", c => c.String());
            AddColumn("dbo.Pomiary", "Klucz", c => c.String());
            AddColumn("dbo.Uzytkownicy", "Klucz", c => c.String());
            AddColumn("dbo.Posilki", "Klucz", c => c.String());
            AddColumn("dbo.PoziomyAktywnosci", "Klucz", c => c.String());
            AddColumn("dbo.SkladnikiJadlospisu", "Klucz", c => c.String());
            AddColumn("dbo.StatusyPacjentow", "Klucz", c => c.String());
            AddColumn("dbo.TypyUzytkownikow", "Klucz", c => c.String());
            AddColumn("dbo.TypyWpisow", "Klucz", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TypyWpisow", "Klucz");
            DropColumn("dbo.TypyUzytkownikow", "Klucz");
            DropColumn("dbo.StatusyPacjentow", "Klucz");
            DropColumn("dbo.SkladnikiJadlospisu", "Klucz");
            DropColumn("dbo.PoziomyAktywnosci", "Klucz");
            DropColumn("dbo.Posilki", "Klucz");
            DropColumn("dbo.Uzytkownicy", "Klucz");
            DropColumn("dbo.Pomiary", "Klucz");
            DropColumn("dbo.Tygodnie", "Klucz");
            DropColumn("dbo.Diety", "Klucz");
            DropColumn("dbo.Pacjenci", "Klucz");
            DropColumn("dbo.Receptura", "Klucz");
            DropColumn("dbo.Skladniki", "Klucz");
            DropColumn("dbo.KategorieSkladnikow", "Klucz");
            DropColumn("dbo.KategorieDan", "Klucz");
            DropColumn("dbo.Dni", "Klucz");
            DropColumn("dbo.RecepturyJadlospisu", "Klucz");
            DropColumn("dbo.PlanyDni", "Klucz");
            DropColumn("dbo.DaniaJadlospisu", "Klucz");
            DropColumn("dbo.PrzeznaczeniaDan", "Klucz");
            DropColumn("dbo.Dania", "Klucz");
        }
    }
}
