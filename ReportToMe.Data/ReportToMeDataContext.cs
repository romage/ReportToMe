using ReportToMe.Models;
using ReportToMe.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Data
{
    public class ReportToMeDataContext  : DbContext 
    {
        public ReportToMeDataContext()
            : base("DefaultConnection")
        {
            
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<MeetingProject> MeetingProjects { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentUpdate> DepartmentUpdates { get; set; }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

   
}
