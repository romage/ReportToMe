namespace ReportToMe.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MeetingUpdates", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.MeetingUpdates", "Meeting_Id", "dbo.Meetings");
            DropIndex("dbo.MeetingUpdates", new[] { "Department_Id" });
            DropIndex("dbo.MeetingUpdates", new[] { "Meeting_Id" });
            RenameColumn(table: "dbo.MeetingUpdates", name: "Department_Id", newName: "DepartmentId");
            RenameColumn(table: "dbo.MeetingUpdates", name: "Meeting_Id", newName: "MeetingId");
            AddColumn("dbo.MeetingUpdates", "Content", c => c.String());
            AlterColumn("dbo.MeetingUpdates", "DepartmentId", c => c.Int(nullable: false));
            AlterColumn("dbo.MeetingUpdates", "MeetingId", c => c.Int(nullable: false));
            CreateIndex("dbo.MeetingUpdates", "DepartmentId");
            CreateIndex("dbo.MeetingUpdates", "MeetingId");
            AddForeignKey("dbo.MeetingUpdates", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.MeetingUpdates", "MeetingId", "dbo.Meetings", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MeetingUpdates", "MeetingId", "dbo.Meetings");
            DropForeignKey("dbo.MeetingUpdates", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.MeetingUpdates", new[] { "MeetingId" });
            DropIndex("dbo.MeetingUpdates", new[] { "DepartmentId" });
            AlterColumn("dbo.MeetingUpdates", "MeetingId", c => c.Int());
            AlterColumn("dbo.MeetingUpdates", "DepartmentId", c => c.Int());
            DropColumn("dbo.MeetingUpdates", "Content");
            RenameColumn(table: "dbo.MeetingUpdates", name: "MeetingId", newName: "Meeting_Id");
            RenameColumn(table: "dbo.MeetingUpdates", name: "DepartmentId", newName: "Department_Id");
            CreateIndex("dbo.MeetingUpdates", "Meeting_Id");
            CreateIndex("dbo.MeetingUpdates", "Department_Id");
            AddForeignKey("dbo.MeetingUpdates", "Meeting_Id", "dbo.Meetings", "Id");
            AddForeignKey("dbo.MeetingUpdates", "Department_Id", "dbo.Departments", "Id");
        }
    }
}
