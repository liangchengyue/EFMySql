namespace EntityFramwork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        No = c.String(nullable: false, maxLength: 128, unicode: false, storeType: "nvarchar"),
                        Name = c.String(nullable: false, unicode: false),
                        Credit = c.Single(nullable: false),
                        ParentNo = c.String(maxLength: 128, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.No)
                .ForeignKey("dbo.Course", t => t.ParentNo)
                .Index(t => t.ParentNo);
            
            CreateTable(
                "dbo.SC",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false, storeType: "nvarchar"),
                        StudentNo = c.String(maxLength: 128, unicode: false, storeType: "nvarchar"),
                        CourseNo = c.String(maxLength: 128, unicode: false, storeType: "nvarchar"),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Course", t => t.CourseNo)
                .ForeignKey("dbo.Student", t => t.StudentNo)
                .Index(t => t.CourseNo)
                .Index(t => t.StudentNo);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        No = c.String(nullable: false, maxLength: 128, unicode: false, storeType: "nvarchar"),
                        Name = c.String(nullable: false, unicode: false),
                        Gender = c.String(nullable: false, unicode: false),
                        Phone = c.String(unicode: false),
                        Address = c.String(unicode: false),
                        Birthday = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.No);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SC", "StudentNo", "dbo.Student");
            DropForeignKey("dbo.SC", "CourseNo", "dbo.Course");
            DropForeignKey("dbo.Course", "ParentNo", "dbo.Course");
            DropIndex("dbo.SC", new[] { "StudentNo" });
            DropIndex("dbo.SC", new[] { "CourseNo" });
            DropIndex("dbo.Course", new[] { "ParentNo" });
            DropTable("dbo.Student");
            DropTable("dbo.SC");
            DropTable("dbo.Course");
        }
    }
}
