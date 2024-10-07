using frappe_HRMS.Domain.Base;

namespace frappe_HRMS.Domain.Attendance
{
    public class ShiftType : BaseEntity
    {
        public string? Name { get; set; }
        public TimeOnly? StartTime { get; set; }
        public TimeOnly? EndTime { get; set; }
        public string? RosterColor { get; set; }
        public bool? EnableAutoAttendance { get; set; }
    }
}
