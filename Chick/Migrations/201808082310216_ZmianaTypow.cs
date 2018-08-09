namespace Chick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZmianaTypow : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Dania", "Nazwa", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Dania", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.PrzeznaczeniaDan", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.DaniaJadlospisu", "NazwaDania", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.DaniaJadlospisu", "Opis", c => c.String(unicode: false));
            AlterColumn("dbo.DaniaJadlospisu", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.PlanyDni", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.RecepturyJadlospisu", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.Diety", "Opis", c => c.String(unicode: false));
            AlterColumn("dbo.Diety", "Wykluczenia", c => c.String(unicode: false));
            AlterColumn("dbo.Diety", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.Tygodnie", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.Dni", "Opis", c => c.String(unicode: false));
            AlterColumn("dbo.Dni", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.KategorieDan", "NazwaKategorii", c => c.String(unicode: false));
            AlterColumn("dbo.KategorieDan", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.KategorieSkladnikow", "NazwaKategorii", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.KategorieSkladnikow", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.Skladniki", "NazwaSkladnika", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Skladniki", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.Receptura", "Opis", c => c.String(unicode: false));
            AlterColumn("dbo.Receptura", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.Pacjenci", "Imie", c => c.String(unicode: false));
            AlterColumn("dbo.Pacjenci", "Nazwisko", c => c.String(unicode: false));
            AlterColumn("dbo.Pacjenci", "Opis", c => c.String(unicode: false));
            AlterColumn("dbo.Pacjenci", "Email", c => c.String(unicode: false));
            AlterColumn("dbo.Pacjenci", "NrTelefonu", c => c.String(unicode: false));
            AlterColumn("dbo.Pacjenci", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.Pomiary", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.Plcie", "NazwaPlci", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Uzytkownicy", "Email", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Uzytkownicy", "LinkDoPolecenia", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Uzytkownicy", "Haslo", c => c.String(unicode: false));
            AlterColumn("dbo.Uzytkownicy", "Imie", c => c.String(unicode: false));
            AlterColumn("dbo.Uzytkownicy", "Nazwisko", c => c.String(unicode: false));
            AlterColumn("dbo.Uzytkownicy", "NrTelefonu", c => c.String(unicode: false));
            AlterColumn("dbo.Uzytkownicy", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.Posilki", "NazwaPosilku", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Posilki", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.PoziomyAktywnosci", "NazwaAktywnosci", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.PoziomyAktywnosci", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.SkladnikiJadlospisu", "NazwaSkladnika", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.SkladnikiJadlospisu", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.StatusyPacjentow", "Status", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.StatusyPacjentow", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.TypyUzytkownikow", "Typ", c => c.String(unicode: false));
            AlterColumn("dbo.TypyUzytkownikow", "Klucz", c => c.String(unicode: false));
            AlterColumn("dbo.TypyWpisow", "Typ", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.TypyWpisow", "Klucz", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TypyWpisow", "Klucz", c => c.String());
            AlterColumn("dbo.TypyWpisow", "Typ", c => c.String(nullable: false));
            AlterColumn("dbo.TypyUzytkownikow", "Klucz", c => c.String());
            AlterColumn("dbo.TypyUzytkownikow", "Typ", c => c.String());
            AlterColumn("dbo.StatusyPacjentow", "Klucz", c => c.String());
            AlterColumn("dbo.StatusyPacjentow", "Status", c => c.String(nullable: false));
            AlterColumn("dbo.SkladnikiJadlospisu", "Klucz", c => c.String());
            AlterColumn("dbo.SkladnikiJadlospisu", "NazwaSkladnika", c => c.String(nullable: false));
            AlterColumn("dbo.PoziomyAktywnosci", "Klucz", c => c.String());
            AlterColumn("dbo.PoziomyAktywnosci", "NazwaAktywnosci", c => c.String(nullable: false));
            AlterColumn("dbo.Posilki", "Klucz", c => c.String());
            AlterColumn("dbo.Posilki", "NazwaPosilku", c => c.String(nullable: false));
            AlterColumn("dbo.Uzytkownicy", "Klucz", c => c.String());
            AlterColumn("dbo.Uzytkownicy", "NrTelefonu", c => c.String());
            AlterColumn("dbo.Uzytkownicy", "Nazwisko", c => c.String());
            AlterColumn("dbo.Uzytkownicy", "Imie", c => c.String());
            AlterColumn("dbo.Uzytkownicy", "Haslo", c => c.String());
            AlterColumn("dbo.Uzytkownicy", "LinkDoPolecenia", c => c.String(nullable: false));
            AlterColumn("dbo.Uzytkownicy", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Plcie", "NazwaPlci", c => c.String(nullable: false));
            AlterColumn("dbo.Pomiary", "Klucz", c => c.String());
            AlterColumn("dbo.Pacjenci", "Klucz", c => c.String());
            AlterColumn("dbo.Pacjenci", "NrTelefonu", c => c.String());
            AlterColumn("dbo.Pacjenci", "Email", c => c.String());
            AlterColumn("dbo.Pacjenci", "Opis", c => c.String());
            AlterColumn("dbo.Pacjenci", "Nazwisko", c => c.String());
            AlterColumn("dbo.Pacjenci", "Imie", c => c.String());
            AlterColumn("dbo.Receptura", "Klucz", c => c.String());
            AlterColumn("dbo.Receptura", "Opis", c => c.String());
            AlterColumn("dbo.Skladniki", "Klucz", c => c.String());
            AlterColumn("dbo.Skladniki", "NazwaSkladnika", c => c.String(nullable: false));
            AlterColumn("dbo.KategorieSkladnikow", "Klucz", c => c.String());
            AlterColumn("dbo.KategorieSkladnikow", "NazwaKategorii", c => c.String(nullable: false));
            AlterColumn("dbo.KategorieDan", "Klucz", c => c.String());
            AlterColumn("dbo.KategorieDan", "NazwaKategorii", c => c.String());
            AlterColumn("dbo.Dni", "Klucz", c => c.String());
            AlterColumn("dbo.Dni", "Opis", c => c.String());
            AlterColumn("dbo.Tygodnie", "Klucz", c => c.String());
            AlterColumn("dbo.Diety", "Klucz", c => c.String());
            AlterColumn("dbo.Diety", "Wykluczenia", c => c.String());
            AlterColumn("dbo.Diety", "Opis", c => c.String());
            AlterColumn("dbo.RecepturyJadlospisu", "Klucz", c => c.String());
            AlterColumn("dbo.PlanyDni", "Klucz", c => c.String());
            AlterColumn("dbo.DaniaJadlospisu", "Klucz", c => c.String());
            AlterColumn("dbo.DaniaJadlospisu", "Opis", c => c.String());
            AlterColumn("dbo.DaniaJadlospisu", "NazwaDania", c => c.String(nullable: false));
            AlterColumn("dbo.PrzeznaczeniaDan", "Klucz", c => c.String());
            AlterColumn("dbo.Dania", "Klucz", c => c.String());
            AlterColumn("dbo.Dania", "Nazwa", c => c.String(nullable: false));
        }
    }
}
