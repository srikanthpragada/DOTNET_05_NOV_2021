namespace CsharpDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TPT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                        Fee = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OfflineCourses",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Place = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.OnlineCourses",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Url = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OnlineCourses", "Id", "dbo.Courses");
            DropForeignKey("dbo.OfflineCourses", "Id", "dbo.Courses");
            DropIndex("dbo.OnlineCourses", new[] { "Id" });
            DropIndex("dbo.OfflineCourses", new[] { "Id" });
            DropTable("dbo.OnlineCourses");
            DropTable("dbo.OfflineCourses");
            DropTable("dbo.Courses");
        }
    }
}
