namespace ReportToMe.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
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
                "dbo.DepartmentUpdates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MeetingProjectId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.MeetingProjects", t => t.MeetingProjectId, cascadeDelete: true)
                .Index(t => t.MeetingProjectId)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.MeetingProjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MeetingId = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Meetings", t => t.MeetingId, cascadeDelete: true)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.MeetingId)
                .Index(t => t.ProjectId);
            
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
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IsArchived = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MeetingProjects", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.MeetingProjects", "MeetingId", "dbo.Meetings");
            DropForeignKey("dbo.DepartmentUpdates", "MeetingProjectId", "dbo.MeetingProjects");
            DropForeignKey("dbo.DepartmentUpdates", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.MeetingProjects", new[] { "ProjectId" });
            DropIndex("dbo.MeetingProjects", new[] { "MeetingId" });
            DropIndex("dbo.DepartmentUpdates", new[] { "DepartmentId" });
            DropIndex("dbo.DepartmentUpdates", new[] { "MeetingProjectId" });
            DropTable("dbo.Projects");
            DropTable("dbo.Meetings");
            DropTable("dbo.MeetingProjects");
            DropTable("dbo.DepartmentUpdates");
            DropTable("dbo.Departments");
        }
    }
}
