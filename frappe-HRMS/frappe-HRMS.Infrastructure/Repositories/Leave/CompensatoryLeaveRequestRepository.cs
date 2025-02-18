using frappe_HRMS.Domain.Leave;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.Leave;

namespace frappe_HRMS.Infrastructure.Services.Leave
{
    public class CompensatoryLeaveRequestRepository : GenericRepository<CompensatoryLeaveRequest>, ICompensatoryLeaveRequestRepository
    {
        public CompensatoryLeaveRequestRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
