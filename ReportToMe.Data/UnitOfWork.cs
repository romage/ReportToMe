using ReportToMe.Interfaces;
using ReportToMe.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Data
{
    public class UnitOfWork: IUnitOfWork, IDisposable // <T>:  IUnitOfWork<T> where T: IEntity
    {
        //private readonly IRepository<T> repository;
        private ReportToMeDataContext _ctx;

        //public UnitOfWork(ReportToMeDataContext dbContext, IRepository<T> repository)
        public UnitOfWork(ReportToMeDataContext dbContext)
        {
            //this.repository = repository;
            this._ctx = dbContext;
        }

        public void SaveChanges()
        {
            _ctx.SaveChanges();
        }


        public async Task<int> SaveChangesAsync()
        {
           return await _ctx.SaveChangesAsync();
        }


        public void Dispose()
        {
            if (_ctx != null)
            {
                _ctx.Dispose();
                _ctx = null;
            }
        }
    }
}
