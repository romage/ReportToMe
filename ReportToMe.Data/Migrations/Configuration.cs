namespace ReportToMe.Data.Migrations
{
    using ReportToMe.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ReportToMe.Data.ReportToMeDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            
        }

        protected override void Seed(ReportToMe.Data.ReportToMeDataContext context)
        {
            
            context.Set<Project>().AddOrUpdate(
                proj=>proj.Description,
                    new Project{ Description="test project 1", Id=1},
                    new Project {Description = "test project 2", Id=2}
                );

            context.Set<Department>().AddOrUpdate(
                dept => dept.Name,
                    new Department{ Name="finance", Id=1},
                    new Department{ Name="technology", Id=2}, 
                    new Department { Name ="marketing", Id=3}
                );

            context.Set<Meeting>().AddOrUpdate(
                i => i.Description,
                    new Meeting
                    {
                        Id = 1,
                        Description = "test 1 meeting",
                        MeetingDate = DateTime.Now,
                        MeetingUpdates = {
                            new MeetingUpdate{ Id = 1, ProjectId=1, DepartmentId=1, Content="test update from the finance dept"},
                            new MeetingUpdate{ Id=2, ProjectId=1, DepartmentId=2, Content="test updated from the tech dept"}
                        }
                    }
                );
        }
    }
}
