namespace ReportToMe.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MeetingDate = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MeetingUpdates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectId = c.Int(nullable: false),
                        Director_Id = c.Int(),
                        Meeting_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Director_Id)
                .ForeignKey("dbo.Meetings", t => t.Meeting_Id)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId)
                .Index(t => t.Director_Id)
                .Index(t => t.Meeting_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        IsArchived = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MeetingUpdates", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.MeetingUpdates", "Meeting_Id", "dbo.Meetings");
            DropForeignKey("dbo.MeetingUpdates", "Director_Id", "dbo.Departments");
            DropIndex("dbo.MeetingUpdates", new[] { "Meeting_Id" });
            DropIndex("dbo.MeetingUpdates", new[] { "Director_Id" });
            DropIndex("dbo.MeetingUpdates", new[] { "ProjectId" });
            DropTable("dbo.Projects");
            DropTable("dbo.MeetingUpdates");
            DropTable("dbo.Meetings");
            DropTable("dbo.Departments");
        }
    }
}
