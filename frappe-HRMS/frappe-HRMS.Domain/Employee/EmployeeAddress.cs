using frappe_HRMS.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Domain.Employee
{
    public class EmployeeAddress : BaseEntity
    {
        public string? Mobile { get; set; }
        public string? PersonalEmail { get; set; }
        public string? CompanyName { get; set; }
        public string? PreferedContactEmail { get; set; }
        public string? CurrentAddress { get; set; }
        public bool? CurrentAddressIs { get; set; }
        public string? PermanentAddress { get; set; }
        public bool? PermanentAddressIs { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyPhone { get; set; }
        public string? Relation { get; set; }
    }
}
