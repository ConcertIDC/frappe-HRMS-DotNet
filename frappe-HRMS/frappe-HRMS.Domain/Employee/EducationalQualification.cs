using frappe_HRMS.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Domain.Employee
{
    public class EducationalQualification : BaseEntity
    {
        public string? School {  get; set; }
        public string? Qualification { get; set; }
        public string? Level { get; set; }
        public int? YearOfPassing { get; set; }
        public decimal? Percentage { get; set; }
        public string? MajorSubjects { get; set; }
    }
}
