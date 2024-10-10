using frappe_HRMS.Domain.Attendance;
using frappe_HRMS.Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace frappe_HRMS.Domain.Employee
{
    public class EmployeeAttendanceLeaves : BaseEntity
    {
        public string? AttendanceDeviceID { get; set; }
        public int? HolidayListId { get; set; }
        [ForeignKey(nameof(HolidayListId))]
        public virtual HolidayList? HolidayList { get; set; }
        public int? ShiftTypeId { get; set; }
        [ForeignKey(nameof(ShiftTypeId))]
        public virtual ShiftType? ShiftType { get; set; }
        public int? ExpenseApproverId { get; set; }
        [ForeignKey(nameof(ExpenseApproverId))]
        public virtual User? ExpenseApprover { get; set; }
        public int? ShiftRequestApproverId { get; set; }
        [ForeignKey(nameof(ShiftRequestApproverId))]
        public virtual User? ShiftRequestApprover { get; set; }
        public int? LeaveApproverId { get; set; }
        [ForeignKey(nameof(LeaveApproverId))]
        public virtual User? LeaveApprover { get; set; }
    }
}
