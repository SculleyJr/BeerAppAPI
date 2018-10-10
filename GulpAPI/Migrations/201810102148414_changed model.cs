namespace GulpAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedmodel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Breweries", "Established");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Breweries", "Established", c => c.Int(nullable: false));
        }
    }
}
