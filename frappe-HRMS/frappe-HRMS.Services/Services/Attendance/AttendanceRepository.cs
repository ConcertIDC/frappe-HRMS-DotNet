using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Attendance;

namespace frappe_HRMS.Services.Services.Attendance
{
    public class AttendanceRepository : GenericRepository<Domain.Attendance.Attendance>, IAttendanceRepository
    {
        public AttendanceRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
