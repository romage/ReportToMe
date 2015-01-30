using ReportToMe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Models
{
    public class Project : IEntity
    {
        public Project()
        {
            MeetingProjects= new List<MeetingProject>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsArchived { get; set;  }
        public ICollection<MeetingProject> MeetingProjects { get; set; }
    }
}
