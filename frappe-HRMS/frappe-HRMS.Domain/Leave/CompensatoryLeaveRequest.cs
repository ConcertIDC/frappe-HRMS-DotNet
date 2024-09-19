using frappe_HRMS.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Leave
{
    public class CompensatoryLeaveRequest : BaseEntity
    {
        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public virtual Employee.Employee? Employee { get; set; }
        public int? LeaveTypeId { get; set; }
        [ForeignKey(nameof(LeaveTypeId))]
        public virtual LeaveType? LeaveType { get; set; }
        public DateTime? WorkFromDate { get; set; }
        public DateTime? WorkEndDate { get; set; }
        public DateTime? HalfDayDate { get; set; }
        public bool? HalfDay {  get; set; }
        public string? Reason { get; set; }
    }
}
