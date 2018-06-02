namespace Chick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testbazy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posilki", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posilki", "Discriminator");
        }
    }
}
