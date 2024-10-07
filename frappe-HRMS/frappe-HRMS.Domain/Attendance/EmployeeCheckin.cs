using frappe_HRMS.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Attendance
{
    public class EmployeeCheckin : BaseEntity
    {
        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee.Employee? Employee { get; set; }
        public DateTime? Time { get; set; }
        public string? LogType { get; set; }
        public string? Location_Device_Id { get; set; }
        public bool? SkipAutoAttendance { get; set; }
    }
}
