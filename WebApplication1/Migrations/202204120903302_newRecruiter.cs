namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newRecruiter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Recruiters", "Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Recruiters", "Id");
            AddForeignKey("dbo.Recruiters", "Id", "dbo.UserRoleRegs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recruiters", "Id", "dbo.UserRoleRegs");
            DropIndex("dbo.Recruiters", new[] { "Id" });
            DropColumn("dbo.Recruiters", "Id");
        }
    }
}