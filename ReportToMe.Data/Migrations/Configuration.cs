namespace ReportToMe.Data.Migrations
{
    using ReportToMe.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<ReportToMe.Data.ReportToMeDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ReportToMe.Data.ReportToMeDataContext context)
        {
             context.Meetings.AddOrUpdate(m => m.Id,
                new Meeting { Id=1,  Description = "Daily catch up", MeetingDate = DateTime.Today.AddDays(-14) },
                new Meeting { Id=2,  Description = "Daily catch up", MeetingDate = DateTime.Today.AddDays(-7) },
                new Meeting { Id=3,  Description = "Daily catch up", MeetingDate = DateTime.Today }
            );


            var proj1 = new Project { Id = 1 , Name = "Test Project 1", Description = "this is a test project ... 1", IsArchived = false };
            var proj2 = new Project { Id = 2 , Name = "Test Project 2", Description = "this is a test project ... 2", IsArchived = true };
            var proj3 = new Project { Id = 3 , Name = "Test Project 3", Description = "this is a test project ... 3", IsArchived = false };
            context.Projects.AddOrUpdate(p => p.Id,
                    proj1, proj2, proj3
            );

            var dept1 = new Department { Id = 1, Name = "MD" };
            var dept2 = new Department { Id = 2, Name = "Finance" };
            var dept3 = new Department { Id = 3, Name = "Marketing" };
            var dept4 = new Department { Id = 4, Name = "Operations" };

            context.Departments.AddOrUpdate(dept => dept.Id,
                    dept1, dept2, dept3, dept4
                    );

            var mp1 = new MeetingProject { Id = 1, MeetingId = 1, ProjectId =1 };
            var mp2 = new MeetingProject { Id = 2, MeetingId = 1, ProjectId = 2 };
            var mp3 = new MeetingProject { Id = 3, MeetingId = 1, ProjectId = 3 };

            context.MeetingProjects.AddOrUpdate(mp => mp.Id,
                    mp1, mp2, mp3
                );


            context.DepartmentUpdates.AddOrUpdate(mpd => mpd.Id,
                new DepartmentUpdate { Id = 1, MeetingProjectId = 1, DepartmentId = 1, Content="content from dept1" },
                new DepartmentUpdate { Id = 2, MeetingProjectId = 1, DepartmentId = 2, Content = "content from dept2" },
                new DepartmentUpdate { Id = 3, MeetingProjectId = 1, DepartmentId = 3, Content = "content from dept3" },

                new DepartmentUpdate { Id = 4, MeetingProjectId = 2, DepartmentId = 1, Content = "content from dept1" },
                new DepartmentUpdate { Id = 5, MeetingProjectId = 2, DepartmentId = 2, Content = "content from dept2" },
                new DepartmentUpdate { Id = 6, MeetingProjectId = 2, DepartmentId = 3, Content = "content from dept3" },

                new DepartmentUpdate { Id = 7, MeetingProjectId = 3, DepartmentId = 1, Content = "content from dept1" },
                new DepartmentUpdate { Id = 8, MeetingProjectId = 3, DepartmentId = 2, Content = "content from dept2" },
                new DepartmentUpdate { Id = 9, MeetingProjectId = 3, DepartmentId = 3, Content = "content from dept3" },
                new DepartmentUpdate { Id = 10, MeetingProjectId = 3, DepartmentId = 4, Content = "content from dept4" }
               );

            




        }
    }
}
