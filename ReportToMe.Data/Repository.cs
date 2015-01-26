using ReportToMe.Interfaces;
using ReportToMe.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Data
{
    public class Repository<T> : IRepository<T> where T: IEntity
    {
        private ReportToMeDataContext _ctx;

        public Repository(ReportToMeDataContext dbContext)
        {
            this._ctx = dbContext;
        }
        public void Dispose()
        {
            
        }

        public Task<IEnumerable<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
