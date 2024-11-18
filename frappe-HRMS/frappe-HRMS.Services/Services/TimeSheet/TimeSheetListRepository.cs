using frappe_HRMS.Domain.TimeSheets;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.TimeSheet;

namespace frappe_HRMS.Services.Services.TimeSheet
{
    public class TimeSheetListRepository : GenericRepository<TimeSheetList>, ITimeSheetListRepository
    {
        public TimeSheetListRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
