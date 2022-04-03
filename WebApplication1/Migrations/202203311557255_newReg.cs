namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newReg : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Registrations", t => t.Registration_Id)
                .Index(t => t.Registration_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "Registration_Id", "dbo.Registrations");
            DropIndex("dbo.Roles", new[] { "Registration_Id" });
            DropTable("dbo.Roles");
        }
    }
}
