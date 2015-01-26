﻿using ReportToMe.Interfaces;
using ReportToMe.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Models
{
    public class Project : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsArchived { get; set;  }
    }
}
