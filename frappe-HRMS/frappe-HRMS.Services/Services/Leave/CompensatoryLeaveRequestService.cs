using frappe_HRMS.Domain.Leave;
using frappe_HRMS.Services.Interfaces.Leave;

namespace frappe_HRMS.Services.Services.Leave
{
    public class CompensatoryLeaveRequestService : GenericService<CompensatoryLeaveRequest>, ICompensatoryLeaveRequestService
    {
        public CompensatoryLeaveRequestService(Infrastructure.Interfaces.IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
