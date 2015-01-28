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
            MeetingUpdates = new List<MeetingUpdate>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsArchived { get; set;  }
        public List<MeetingUpdate> MeetingUpdates { get; set; }
    }
}
