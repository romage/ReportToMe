using ReportToMe.Interfaces;
using ReportToMe.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Models
{
    public class Department :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Meeting> Meetings { get; set; }
        public ICollection<MeetingUpdate> MeetingUpdates { get; set; }
      
    }
}
