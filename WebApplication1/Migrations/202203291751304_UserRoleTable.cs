namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserRoleTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRoleRegs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleModelId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        UserName = c.String(),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Registrations", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.RoleModels", t => t.RoleModelId, cascadeDelete: true)
                .Index(t => t.RoleModelId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoleRegs", "RoleModelId", "dbo.RoleModels");
            DropForeignKey("dbo.UserRoleRegs", "UserId", "dbo.Registrations");
            DropIndex("dbo.UserRoleRegs", new[] { "UserId" });
            DropIndex("dbo.UserRoleRegs", new[] { "RoleModelId" });
            DropTable("dbo.UserRoleRegs");
        }
    }
}
