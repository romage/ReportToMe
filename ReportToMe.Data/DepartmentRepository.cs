using ReportToMe.Models;
using ReportToMe.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Data
{
    public class DepartmentRepository: Repository<Department>, IDepartmentRepository
    {
        ReportToMeDataContext _ctx;

        public DepartmentRepository(ReportToMeDataContext ctx): base(ctx)
        {
            this._ctx = ctx;
        }

        public IEnumerable<DepartmentsForMeeting> DepartmentsForMeeting(int meetingId)
        {
            var ret = _ctx
                .Departments
                .Select(et => new DepartmentsForMeeting
                {
                    Department = et,
                    HasCompleted = et.MeetingUpdates.Any(mu => mu.MeetingId == meetingId),
                    MeetingUpdate = et.MeetingUpdates.FirstOrDefault(mu => mu.MeetingId == meetingId)
                });
               return ret;
        }


        //IEnumerable<DepartmentsForMeeting> IDepartmentRepository.DepartmentsForMeeting(int meetingId)
        //{
        //    var ret = _ctx
        //      .Departments
        //      .Select(et => new DepartmentsForMeeting
        //      {
        //          Department = et,
        //          HasCompleted = et.MeetingUpdates.Any(mu => mu.MeetingId == meetingId),
        //          MeetingUpdate = et.MeetingUpdates.FirstOrDefault(mu => mu.MeetingId == meetingId)
        //      });
        //    return ret;          
        //}

        //Task<IEnumerable<Department>> IRepository<Department>.ListAllAsync()
        //{
        //    return base.ListAllAsync();
        //}

        //IEnumerable<Department> IRepository<Department>.ListAll()
        //{
        //    return base.ListAll();
        //}

        //Department IRepository<Department>.Find(int id)
        //{
        //    return base.Find(id);
        //}

        //Department IRepository<Department>.Add(Department entity)
        //{
        //    return base.Add(entity);
        //}

        //Department IRepository<Department>.Update(Department entity)
        //{
        //    return base.Update(entity);
        //}

        //void IRepository<Department>.Delete(Department entity)
        //{
        //    base.Delete(entity);
        //}

        //void IRepository<Department>.Dispose()
        //{
        //    base.Dispose();
        //}

        //void IDisposable.Dispose()
        //{
        //    base.Dispose();
        //}
    }
}
