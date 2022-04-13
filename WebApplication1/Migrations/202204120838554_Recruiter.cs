namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recruiter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recruiters",
                c => new
                {
                    UserId = c.Int(nullable: false, identity: true),
                    Firstname = c.String(nullable: false),
                    Lastname = c.String(nullable: false),
                    Phone = c.String(nullable: false),
                    Email = c.String(nullable: false),
                })
                .PrimaryKey(t => t.UserId);
               
        }

        public override void Down()
        {
            DropTable("dbo.Recruiters");
        }
    }
}
