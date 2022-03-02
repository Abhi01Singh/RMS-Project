namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registrations", "Fname", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "Lname", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "Password", c => c.String(nullable: false, maxLength: 100));
            
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registrations", "Password", c => c.String());
            AlterColumn("dbo.Registrations", "Email", c => c.String());
            AlterColumn("dbo.Registrations", "Phone", c => c.String());
            AlterColumn("dbo.Registrations", "Lname", c => c.String());
            AlterColumn("dbo.Registrations", "Fname", c => c.String());
        }
    }
}
