namespace Chick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanieGodziny : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PlanyDni", "Godzina", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PlanyDni", "Godzina");
        }
    }
}
