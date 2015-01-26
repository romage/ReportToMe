using ReportToMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Web.Interfaces
{
    public interface IProjectService : IDisposable
    {
        IEnumerable<Project> List();
        IEnumerable<Project> List(Func<Project, bool> where);
        Project Find(Func<Project, bool> where);
        Project Add(Project entity);
        bool Delete(int Id);
        bool Delete(Project entity);
    }
}
