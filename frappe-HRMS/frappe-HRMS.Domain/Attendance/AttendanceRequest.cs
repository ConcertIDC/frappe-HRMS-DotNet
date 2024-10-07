using frappe_HRMS.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Domain.Attendance
{
    public class AttendanceRequest : BaseEntity
    {
        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee.Employee? Employee { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public virtual Company.Company? Company { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? HalfDay { get; set; }
        public DateTime? HalfDayDate { get; set; }
        public bool? IncludeHolidays { get; set; }
        public int? ShiftTypeId { get; set; }
        [ForeignKey(nameof(ShiftTypeId))]
        public virtual ShiftType? ShiftType { get; set; }
        public string? Reason { get; set; }
        public string? Explanation { get; set; }
    }
}
