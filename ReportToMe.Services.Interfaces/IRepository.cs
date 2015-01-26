using ReportToMe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Services.Interfaces
{
    public interface IRepository<T> where T : IEntity 
    {
        Task<IEnumerable<T>> ListAllAsync();
        IEnumerable<T> ListAll();
    }
}
