using frappe_HRMS.Domain.Attendance;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Attendance;

namespace frappe_HRMS.Services.Services.Attendance
{
    public class EmployeeCheckinService : GenericService<EmployeeCheckin>, IEmployeeCheckinService
    {
        public EmployeeCheckinService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
