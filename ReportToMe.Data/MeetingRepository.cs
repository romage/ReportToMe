using ReportToMe.Models;
using ReportToMe.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Data
{
    public class MeetingRepository : Repository<Meeting>, IMeetingRepository
    {
        ReportToMeDataContext _ctx;

        public MeetingRepository(ReportToMeDataContext ctx)
            : base(ctx)
        {
            this._ctx = ctx;
        }

        public Meeting MeetingsWithAllDepartments(int meetingId)
        {
            var depts = _ctx.Departments.ToList();

            var meeting = _ctx.Meetings.Where(m=>m.Id== meetingId).FirstOrDefault();
            if (meeting != null)
            {
                foreach (var mp in meeting.MeetingProjects)
                {
                    foreach (var d in depts)
                    {
                        if (!mp.DepartmentUpdates.Where(du => du.DepartmentId == d.Id).Any())
                        {
                            var newdu = new DepartmentUpdate {  Department = d, MeetingProject = mp, Content = "Not updated yet" };
                            mp.DepartmentUpdates.Add(newdu);
                        }
                    }
                }
            }
            return meeting;            
        }


        public bool UpdateContent(int meetingProjectId, int departmentId, int departmentUpdateId, string newContent)
        {
            if (departmentUpdateId == 0)
            {
                DepartmentUpdate du = new DepartmentUpdate { Content = newContent, DepartmentId = departmentId, MeetingProjectId = meetingProjectId };
                _ctx.DepartmentUpdates.Add(du);
            }
            else 
            {
                DepartmentUpdate du = _ctx.DepartmentUpdates.Find(departmentUpdateId);
                du.Content = newContent;
                _ctx.SaveChanges();
            }
            _ctx.SaveChanges();
            return true;
        }
    }
}
