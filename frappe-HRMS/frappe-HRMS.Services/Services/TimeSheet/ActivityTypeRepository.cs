using frappe_HRMS.Domain.TimeSheets;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.TimeSheet;

namespace frappe_HRMS.Services.Services.TimeSheet
{
    public class ActivityTypeRepository : GenericRepository<ActivityType>, IActivityTypeRepository
    {
        public ActivityTypeRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
