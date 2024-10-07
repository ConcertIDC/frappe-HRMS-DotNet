using frappe_HRMS.Domain.Attendance;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Attendance;

namespace frappe_HRMS.Services.Services.Attendance
{
    public class EmployeeCheckinRepository : GenericRepository<EmployeeCheckin>, IEmployeeCheckinRepository
    {
        public EmployeeCheckinRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
