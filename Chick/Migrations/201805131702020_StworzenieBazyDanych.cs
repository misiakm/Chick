namespace Chick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StworzenieBazyDanych : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dania",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nazwa = c.String(nullable: false),
                        WagaPorcji = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Uzytkownik = c.Int(),
                        Kategoria = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.KategorieDan", t => t.Kategoria)
                .ForeignKey("dbo.Uzytkownicy", t => t.Uzytkownik)
                .Index(t => t.Uzytkownik)
                .Index(t => t.Kategoria);
            
            CreateTable(
                "dbo.PrzeznaczeniaDan",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Danie = c.Int(nullable: false),
                        Posilek = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Dania", t => t.Danie, cascadeDelete: true)
                .ForeignKey("dbo.Posilki", t => t.Posilek, cascadeDelete: true)
                .Index(t => t.Danie)
                .Index(t => t.Posilek);
            
            CreateTable(
                "dbo.DaniaJadlospisu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NazwaDania = c.String(nullable: false),
                        Waga = c.Int(nullable: false),
                        TypWpisu = c.Int(nullable: false),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TypyWpisow", t => t.TypWpisu, cascadeDelete: true)
                .Index(t => t.TypWpisu);
            
            CreateTable(
                "dbo.PlanyDni",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Dzien = c.Int(nullable: false),
                        DanieJadlospisu = c.Int(nullable: false),
                        Posilek = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DaniaJadlospisu", t => t.DanieJadlospisu, cascadeDelete: true)
                .ForeignKey("dbo.Dni", t => t.Dzien, cascadeDelete: true)
                .ForeignKey("dbo.Posilki", t => t.Posilek, cascadeDelete: true)
                .Index(t => t.Dzien)
                .Index(t => t.DanieJadlospisu)
                .Index(t => t.Posilek);
            
            CreateTable(
                "dbo.RecepturyJadlospisu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Skladnik = c.Int(nullable: false),
                        Waga = c.Int(nullable: false),
                        DanieJadlospisu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DaniaJadlospisu", t => t.DanieJadlospisu, cascadeDelete: true)
                .ForeignKey("dbo.SkladnikiJadlospisu", t => t.Skladnik, cascadeDelete: true)
                .Index(t => t.Skladnik)
                .Index(t => t.DanieJadlospisu);
            
            CreateTable(
                "dbo.Dni",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        Tydzien = c.Int(nullable: false),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tygodnie", t => t.Tydzien, cascadeDelete: true)
                .Index(t => t.Tydzien);
            
            CreateTable(
                "dbo.KategorieDan",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NazwaKategorii = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KategorieSkladnikow",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NazwaKategorii = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Skladniki",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NazwaSkladnika = c.String(nullable: false),
                        Kalorycznosc = c.Int(nullable: false),
                        Bialko = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tluszcz = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weglowodanych = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Uzytkownik = c.Int(),
                        Kategoria = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.KategorieSkladnikow", t => t.Kategoria)
                .ForeignKey("dbo.Uzytkownicy", t => t.Uzytkownik)
                .Index(t => t.Uzytkownik)
                .Index(t => t.Kategoria);
            
            CreateTable(
                "dbo.Receptura",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Skladnik = c.Int(nullable: false),
                        Danie = c.Int(nullable: false),
                        Opis = c.String(),
                        Waga = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Skladniki", t => t.Skladnik, cascadeDelete: true)
                .Index(t => t.Skladnik);
            
            CreateTable(
                "dbo.Pacjenci",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Opis = c.String(),
                        Email = c.String(),
                        NrTelefonu = c.String(),
                        Status = c.Int(nullable: false),
                        Dietetyk = c.Int(),
                        Wzrost = c.Int(),
                        Plec = c.Int(),
                        Usuniety = c.Boolean(nullable: false),
                        DataDodania = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Plcie", t => t.Plec)
                .ForeignKey("dbo.Uzytkownicy", t => t.Dietetyk)
                .ForeignKey("dbo.StatusyPacjentow", t => t.Status, cascadeDelete: true)
                .Index(t => t.Status)
                .Index(t => t.Dietetyk)
                .Index(t => t.Plec);
            
            CreateTable(
                "dbo.Diety",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DataPoczatkowa = c.DateTime(nullable: false),
                        DataKoncowa = c.DateTime(nullable: false),
                        IloscTygodni = c.Int(nullable: false),
                        Pacjent = c.Int(nullable: false),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pacjenci", t => t.Pacjent, cascadeDelete: true)
                .Index(t => t.Pacjent);
            
            CreateTable(
                "dbo.Tygodnie",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NrTygodnia = c.Int(nullable: false),
                        Dieta = c.Int(nullable: false),
                        Kalorycznosc = c.Int(nullable: false),
                        Bialko = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tluszcz = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weglowodany = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Diety", t => t.Dieta, cascadeDelete: true)
                .Index(t => t.Dieta);
            
            CreateTable(
                "dbo.Pomiary",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Pacjent = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Masa = c.Decimal(precision: 18, scale: 2),
                        ObwodTalii = c.Decimal(precision: 18, scale: 2),
                        ObwodBioder = c.Decimal(precision: 18, scale: 2),
                        ObwodKlatkiPiersiowej = c.Decimal(precision: 18, scale: 2),
                        ObwodRamienia = c.Decimal(precision: 18, scale: 2),
                        ObwodLydki = c.Decimal(precision: 18, scale: 2),
                        ObwodUda = c.Decimal(precision: 18, scale: 2),
                        PoziomAktywnosciFizycznej = c.Int(nullable: false),
                        Usuniety = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pacjenci", t => t.Pacjent, cascadeDelete: true)
                .ForeignKey("dbo.PoziomyAktywnosci", t => t.PoziomAktywnosciFizycznej, cascadeDelete: true)
                .Index(t => t.Pacjent)
                .Index(t => t.PoziomAktywnosciFizycznej);
            
            CreateTable(
                "dbo.Plcie",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NazwaPlci = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Uzytkownicy",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Typ = c.Int(nullable: false),
                        Email = c.String(nullable: false),
                        Newsletter = c.Boolean(nullable: false),
                        LinkDoPolecenia = c.String(nullable: false),
                        Haslo = c.String(),
                        Imie = c.String(),
                        Nazwisko = c.String(),
                        Plec = c.Int(),
                        NrTelefonu = c.String(),
                        Dietetyk = c.Int(),
                        Usuniety = c.Boolean(nullable: false),
                        DataDodania = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Uzytkownicy", t => t.Dietetyk)
                .ForeignKey("dbo.Plcie", t => t.Plec)
                .ForeignKey("dbo.TypyUzytkownikow", t => t.Typ, cascadeDelete: true)
                .Index(t => t.Typ)
                .Index(t => t.Plec)
                .Index(t => t.Dietetyk);
            
            CreateTable(
                "dbo.Posilki",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NazwaPosilku = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PoziomyAktywnosci",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NazwaAktywnosci = c.String(nullable: false),
                        Wspolczynnik = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SkladnikiJadlospisu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NazwaSkladnika = c.String(nullable: false),
                        Kalorycznosc = c.Int(nullable: false),
                        Bialko = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Tluszcz = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weglowodanych = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StatusyPacjentow",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TypyUzytkownikow",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Typ = c.String(),
                        Usuniety = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TypyWpisow",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Typ = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DaniaJadlospisu", "TypWpisu", "dbo.TypyWpisow");
            DropForeignKey("dbo.Uzytkownicy", "Typ", "dbo.TypyUzytkownikow");
            DropForeignKey("dbo.Pacjenci", "Status", "dbo.StatusyPacjentow");
            DropForeignKey("dbo.RecepturyJadlospisu", "Skladnik", "dbo.SkladnikiJadlospisu");
            DropForeignKey("dbo.Pomiary", "PoziomAktywnosciFizycznej", "dbo.PoziomyAktywnosci");
            DropForeignKey("dbo.PrzeznaczeniaDan", "Posilek", "dbo.Posilki");
            DropForeignKey("dbo.PlanyDni", "Posilek", "dbo.Posilki");
            DropForeignKey("dbo.Uzytkownicy", "Plec", "dbo.Plcie");
            DropForeignKey("dbo.Skladniki", "Uzytkownik", "dbo.Uzytkownicy");
            DropForeignKey("dbo.Pacjenci", "Dietetyk", "dbo.Uzytkownicy");
            DropForeignKey("dbo.Uzytkownicy", "Dietetyk", "dbo.Uzytkownicy");
            DropForeignKey("dbo.Dania", "Uzytkownik", "dbo.Uzytkownicy");
            DropForeignKey("dbo.Pacjenci", "Plec", "dbo.Plcie");
            DropForeignKey("dbo.Pomiary", "Pacjent", "dbo.Pacjenci");
            DropForeignKey("dbo.Diety", "Pacjent", "dbo.Pacjenci");
            DropForeignKey("dbo.Tygodnie", "Dieta", "dbo.Diety");
            DropForeignKey("dbo.Dni", "Tydzien", "dbo.Tygodnie");
            DropForeignKey("dbo.Skladniki", "Kategoria", "dbo.KategorieSkladnikow");
            DropForeignKey("dbo.Receptura", "Skladnik", "dbo.Skladniki");
            DropForeignKey("dbo.Dania", "Kategoria", "dbo.KategorieDan");
            DropForeignKey("dbo.PlanyDni", "Dzien", "dbo.Dni");
            DropForeignKey("dbo.RecepturyJadlospisu", "DanieJadlospisu", "dbo.DaniaJadlospisu");
            DropForeignKey("dbo.PlanyDni", "DanieJadlospisu", "dbo.DaniaJadlospisu");
            DropForeignKey("dbo.PrzeznaczeniaDan", "Danie", "dbo.Dania");
            DropIndex("dbo.Uzytkownicy", new[] { "Dietetyk" });
            DropIndex("dbo.Uzytkownicy", new[] { "Plec" });
            DropIndex("dbo.Uzytkownicy", new[] { "Typ" });
            DropIndex("dbo.Pomiary", new[] { "PoziomAktywnosciFizycznej" });
            DropIndex("dbo.Pomiary", new[] { "Pacjent" });
            DropIndex("dbo.Tygodnie", new[] { "Dieta" });
            DropIndex("dbo.Diety", new[] { "Pacjent" });
            DropIndex("dbo.Pacjenci", new[] { "Plec" });
            DropIndex("dbo.Pacjenci", new[] { "Dietetyk" });
            DropIndex("dbo.Pacjenci", new[] { "Status" });
            DropIndex("dbo.Receptura", new[] { "Skladnik" });
            DropIndex("dbo.Skladniki", new[] { "Kategoria" });
            DropIndex("dbo.Skladniki", new[] { "Uzytkownik" });
            DropIndex("dbo.Dni", new[] { "Tydzien" });
            DropIndex("dbo.RecepturyJadlospisu", new[] { "DanieJadlospisu" });
            DropIndex("dbo.RecepturyJadlospisu", new[] { "Skladnik" });
            DropIndex("dbo.PlanyDni", new[] { "Posilek" });
            DropIndex("dbo.PlanyDni", new[] { "DanieJadlospisu" });
            DropIndex("dbo.PlanyDni", new[] { "Dzien" });
            DropIndex("dbo.DaniaJadlospisu", new[] { "TypWpisu" });
            DropIndex("dbo.PrzeznaczeniaDan", new[] { "Posilek" });
            DropIndex("dbo.PrzeznaczeniaDan", new[] { "Danie" });
            DropIndex("dbo.Dania", new[] { "Kategoria" });
            DropIndex("dbo.Dania", new[] { "Uzytkownik" });
            DropTable("dbo.TypyWpisow");
            DropTable("dbo.TypyUzytkownikow");
            DropTable("dbo.StatusyPacjentow");
            DropTable("dbo.SkladnikiJadlospisu");
            DropTable("dbo.PoziomyAktywnosci");
            DropTable("dbo.Posilki");
            DropTable("dbo.Uzytkownicy");
            DropTable("dbo.Plcie");
            DropTable("dbo.Pomiary");
            DropTable("dbo.Tygodnie");
            DropTable("dbo.Diety");
            DropTable("dbo.Pacjenci");
            DropTable("dbo.Receptura");
            DropTable("dbo.Skladniki");
            DropTable("dbo.KategorieSkladnikow");
            DropTable("dbo.KategorieDan");
            DropTable("dbo.Dni");
            DropTable("dbo.RecepturyJadlospisu");
            DropTable("dbo.PlanyDni");
            DropTable("dbo.DaniaJadlospisu");
            DropTable("dbo.PrzeznaczeniaDan");
            DropTable("dbo.Dania");
        }
    }
}
