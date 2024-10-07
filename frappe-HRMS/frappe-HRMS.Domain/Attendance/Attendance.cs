using frappe_HRMS.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace frappe_HRMS.Domain.Attendance
{
    public class Attendance : BaseEntity
    {
        public string Series => $"HR-ATT-{DateTime.Now.Year}-000{Id.ToString()}";
        public DateTime? AttendanceDate { get; set; }
        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee.Employee? Employee { get; set; }
        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public virtual Company.Company? Company { get; set; }
        public string? Status { get; set; }
        public int? ShiftTypeId { get; set; }
        [ForeignKey(nameof(ShiftTypeId))]
        public virtual ShiftType? ShiftType { get; set; }
        public bool? LateEntry { get; set; }
        public bool? EarlyEntry { get; set; }

    }
}
