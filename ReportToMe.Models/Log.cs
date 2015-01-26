using ReportToMe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Models
{
    public class Log : IEntity
    {
        public int Id { get; set; }
        public int DateTime { get; set; }
        public string Message { get; set; }
        public string InnerMessage { get; set; }
        public string LogType { get; set; }
    }
}
