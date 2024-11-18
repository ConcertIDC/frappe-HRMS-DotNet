using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.TimeSheet;

namespace frappe_HRMS.Services.Services.TimeSheet
{
    public class TimeSheetRepository : GenericRepository<Domain.TimeSheets.TimeSheet>, ITimeSheetRepository
    {
        public TimeSheetRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
