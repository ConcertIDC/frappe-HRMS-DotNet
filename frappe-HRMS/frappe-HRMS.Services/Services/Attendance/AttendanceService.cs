using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Attendance;

namespace frappe_HRMS.Services.Services.Attendance
{
    public class AttendanceService : GenericService<Domain.Attendance.Attendance>, IAttendanceService
    {
        public AttendanceService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
