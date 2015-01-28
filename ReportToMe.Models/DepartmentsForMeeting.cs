using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Models
{
    public class DepartmentsForMeeting
    {
        public Department Department { get; set; }
        public bool HasCompleted { get; set; }
        public MeetingUpdate MeetingUpdate { get; set; }
    }
}
