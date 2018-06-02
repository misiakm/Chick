namespace Chick.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testbazy2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Posilki", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posilki", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
