using ReportToMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Services.Interfaces
{
    public interface IMeetingRepository : IRepository<Meeting>
    {
        Meeting MeetingsWithAllDepartments(int meetingId);
        bool UpdateContent(int meetingProjectId,int departmentId, int departmentUpdateId, string newContent);
    }
}
