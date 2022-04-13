namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removedroles : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Roles", "Registration_Id", "dbo.Registrations");
            DropIndex("dbo.Roles", new[] { "Registration_Id" });
            DropTable("dbo.Roles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                        Checked = c.Boolean(nullable: false),
                        Registration_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Roles", "Registration_Id");
            AddForeignKey("dbo.Roles", "Registration_Id", "dbo.Registrations", "Id");
        }
    }
}
