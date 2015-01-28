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

        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingUpdate> MeetingUpdates { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //modelBuilder
            //    .Entity<Department>()
            //        .Property(b => b.Name)
            //            .HasMaxLength(20);

            base.OnModelCreating(modelBuilder);
        }

    }
}
