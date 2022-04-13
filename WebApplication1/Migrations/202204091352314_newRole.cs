namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newRole : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserRoleRegs", "RoleName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserRoleRegs", "RoleName");
        }
    }
}
