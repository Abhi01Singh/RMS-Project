namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removedfileds : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.RoleModels", "IsSelected");
            DropColumn("dbo.UserRoleRegs", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserRoleRegs", "UserName", c => c.String());
            AddColumn("dbo.RoleModels", "IsSelected", c => c.Boolean(nullable: false));
        }
    }
}
