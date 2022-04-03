namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newRegR : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Roles", "Checked");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Roles", "Checked", c => c.Boolean(nullable: false));
        }
    }
}
