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

        DbSet<Department> Departments { get; set; }
        DbSet<Project> Projects { get; set; }
        DbSet<Meeting> Meetings { get; set; }
        DbSet<MeetingUpdate> MeetingUpdates { get; set; }
        


    }
}
