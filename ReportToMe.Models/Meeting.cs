using ReportToMe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Models
{
    public class Meeting : IEntity
    {
        public Meeting()
        {
            MeetingProjects = new List<MeetingProject>();
        }
        public int Id { get; set; }
        public DateTime MeetingDate { get; set; }
        public string Description { get; set; }
        public virtual ICollection<MeetingProject> MeetingProjects {get; set ;}
        
    }
}
