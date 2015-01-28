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
            MeetingUpdates = new List<MeetingUpdate>();
        }
        public int Id { get; set; }
        public DateTime MeetingDate { get; set; }
        public string Description { get; set; }
        public virtual List<MeetingUpdate> MeetingUpdates { get; set; }
        
    }
}
