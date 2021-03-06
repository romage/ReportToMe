﻿using ReportToMe.Models;
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

    }
}
