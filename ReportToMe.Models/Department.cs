using ReportToMe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportToMe.Models
{
    public class Department :IEntity
    {
        public Department()
        {
            this.DepartmentUpdates = new List<DepartmentUpdate>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        ICollection<DepartmentUpdate> DepartmentUpdates { get; set; }
      
    }
}
