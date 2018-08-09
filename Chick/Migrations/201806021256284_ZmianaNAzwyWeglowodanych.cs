namespace Chick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZmianaNAzwyWeglowodanych : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SkladnikiJadlospisu", "Weglowodany", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.SkladnikiJadlospisu", "Weglowodanych");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SkladnikiJadlospisu", "Weglowodanych", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.SkladnikiJadlospisu", "Weglowodany");
        }
    }
}
