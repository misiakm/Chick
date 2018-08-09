namespace Chick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsunWageZDania : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DaniaJadlospisu", "Waga");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DaniaJadlospisu", "Waga", c => c.Int(nullable: false));
        }
    }
}
