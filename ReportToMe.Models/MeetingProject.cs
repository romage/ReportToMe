using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Models
{
    public class MeetingProject
    {
        public MeetingProject()
        {
            this.DepartmentUpdates = new List<DepartmentUpdate>();
        }
        public int Id { get; set; }
       
        public Meeting Meeting { get; set; }
        public virtual Project Project{ get; set; }

        public int MeetingId { get; set; }
        public int ProjectId { get; set; }

        public virtual ICollection<DepartmentUpdate> DepartmentUpdates { get; set; }

    }
}
