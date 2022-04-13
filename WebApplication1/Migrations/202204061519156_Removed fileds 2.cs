namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removedfileds2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserRoleRegs", "RoleName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserRoleRegs", "RoleName", c => c.String());
        }
    }
}
