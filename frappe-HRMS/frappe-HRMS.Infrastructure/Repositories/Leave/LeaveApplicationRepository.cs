using frappe_HRMS.Domain.Leave;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.Leave;

namespace frappe_HRMS.Infrastructure.Services.Leave
{
    public class LeaveApplicationRepository : GenericRepository<LeaveApplication>, ILeaveApplicationRepository
    {
        public LeaveApplicationRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
