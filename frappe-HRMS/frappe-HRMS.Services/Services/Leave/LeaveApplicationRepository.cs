using frappe_HRMS.Domain.Leave;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Leave;

namespace frappe_HRMS.Services.Services.Leave
{
    public class LeaveApplicationRepository : GenericRepository<LeaveApplication>, ILeaveApplicationRepository
    {
        public LeaveApplicationRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
