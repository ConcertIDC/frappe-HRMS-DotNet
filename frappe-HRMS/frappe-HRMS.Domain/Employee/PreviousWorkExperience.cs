using frappe_HRMS.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Domain.Employee
{
    public class PreviousWorkExperience : BaseEntity
    {
        public string? Company {  get; set; }
        public string? Designation { get; set; }
        public string? Salary { get; set; }
        public string? Address { get; set;}
        public string? Contact { get; set; }
        public int? TotalExperience { get; set; }

    }
}
