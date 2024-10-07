using frappe_HRMS.Domain.Attendance;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Attendance;

namespace frappe_HRMS.Services.Services.Attendance
{
    public class AttendanceRequestRepository : GenericRepository<AttendanceRequest>, IAttendanceRequestRepository
    {
        public AttendanceRequestRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
