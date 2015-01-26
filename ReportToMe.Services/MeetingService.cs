using ReportToMe.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportToMe.Models;
using ReportToMe.Services.Interfaces;

namespace ReportToMe.Services
{
    public class MeetingService: IMeetingService
    {
        IRepository<Meeting> _repo;
        IUnitOfWork  _uow;

        public MeetingService(IRepository<Meeting> repository, IUnitOfWork unitOfWork)
        {
            this._repo = repository;
            this._uow = unitOfWork;
        }

        public async Task<IEnumerable<Meeting>> ListMeetingsAsync()
        {
            return await _repo.ListAllAsync();
        }

        public Task<IEnumerable<Meeting>> ListMeetingsAsync(Func<Meeting, bool> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Meeting> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Meeting> List(Func<Meeting, bool> where)
        {
            throw new NotImplementedException();
        }

        public Meeting Find(Func<Meeting, bool> where)
        {
            throw new NotImplementedException();
        }

        public Meeting Add(Meeting entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Meeting entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
