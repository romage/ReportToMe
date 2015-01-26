using ReportToMe.Interfaces;
using ReportToMe.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Models
{
    public class MeetingUpdate : IEntity
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public virtual Meeting Meeting { get; set; }
        public virtual Project Project {get; set;}
        public virtual Department Department { get; set; }
    }
}
