namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CP : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registrations", "ConfirmPassword", c => c.String());
        }
        
        public override void Down()
        {
            
            DropColumn("dbo.Registrations", "ConfirmPassword");
        }
    }
}
