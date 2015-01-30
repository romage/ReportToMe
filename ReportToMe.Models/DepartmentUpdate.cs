using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Models
{
    public class DepartmentUpdate
    {
        public int Id { get; set; }
        public int MeetingProjectId { get; set; }
        public int DepartmentId { get; set; }
        public MeetingProject MeetingProject { get; set; }
        public virtual Department Department { get; set; }
        public string Content { get; set; }
    }
}
