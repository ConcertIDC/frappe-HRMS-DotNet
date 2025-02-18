using frappe_HRMS.Domain.Leave;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Leave;

namespace frappe_HRMS.Services.Services.Leave
{
    public class LeaveApplicationService : GenericService<LeaveApplication>, ILeaveApplicationService
    {
        public LeaveApplicationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
