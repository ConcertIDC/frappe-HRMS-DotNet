using frappe_HRMS.Domain.Base;

namespace frappe_HRMS.Domain.Attendance
{
    public class HolidayList : BaseEntity
    {
        public string? HolidayListName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? TotalHolidays { get; set; }
    }
}
