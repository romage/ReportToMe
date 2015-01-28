using ReportToMe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Services.Interfaces
{
    public interface IUnitOfWork: IDisposable// <T>: IDisposable where T: IEntity
    {
        void SaveChanges();
        Task<int> SaveChangesAsync();
        //void Dispose(); 
    }
}
