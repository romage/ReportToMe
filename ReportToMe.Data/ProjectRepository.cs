using ReportToMe.Models;
using ReportToMe.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Data
{
    class ProjectRepository: Repository<Project>, IProjectRepository
    {
        ReportToMeDataContext _ctx;
        
        public ProjectRepository(ReportToMeDataContext ctx): base(ctx)
        {
            this._ctx = ctx;
        }

        
    }


}
