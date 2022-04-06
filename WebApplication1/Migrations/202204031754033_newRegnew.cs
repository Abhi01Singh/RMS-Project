namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newRegnew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "Checked", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Roles", "Checked");
        }
    }
}
