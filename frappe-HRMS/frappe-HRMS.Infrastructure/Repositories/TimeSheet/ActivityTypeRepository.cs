using frappe_HRMS.Domain.TimeSheets;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.TimeSheet;

namespace frappe_HRMS.Infrastructure.Services.TimeSheet
{
    public class ActivityTypeRepository : GenericRepository<ActivityType>, IActivityTypeRepository
    {
        public ActivityTypeRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
