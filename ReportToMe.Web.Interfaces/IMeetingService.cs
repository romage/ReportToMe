﻿using ReportToMe.Models;
using ReportToMe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Web.Interfaces
{
    public interface IMeetingService: IDisposable
    {
        Task<IEnumerable<Meeting>> ListMeetingsAsync();
        Task<IEnumerable<Meeting>> ListMeetingsAsync(Func<Meeting, bool> where);

        IEnumerable<Meeting> List();
        IEnumerable<Meeting> List(Func<Meeting, bool> where);
        Meeting MeetingsWithAllDepartments(int meetingId);
        Meeting Find(Func<Meeting, bool> where);
        Meeting Add(Meeting entity);
     
        bool Delete(int Id);
        bool Delete(Meeting entity);

        bool UpdateContent(int meetingProjectId,int departmentId, int departmentUpdateId, string newContent);
    }
}
