namespace Chick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZmianyNaBazie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Diety", "Wykluczenia", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Diety", "Wykluczenia");
        }
    }
}
