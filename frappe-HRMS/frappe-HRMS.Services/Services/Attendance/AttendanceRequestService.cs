using frappe_HRMS.Domain.Attendance;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Attendance;

namespace frappe_HRMS.Services.Services.Attendance
{
    public class AttendanceRequestService : GenericService<AttendanceRequest>, IAttendanceRequestService
    {
        public AttendanceRequestService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
