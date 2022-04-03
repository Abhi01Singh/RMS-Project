namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newRegrole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registrations", "RoleName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Registrations", "RoleName");
        }
    }
}
