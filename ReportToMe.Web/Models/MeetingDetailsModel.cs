using ReportToMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportToMe.Web.Models
{
    public class MeetingDetailsModel
    {
        public Meeting Meeting { get; set; }
        //public List<Department> AllDepartments { get; set; }
        public List<DepartmentsForMeeting> DepartmentsForMeetings { get; set; }
    }
}