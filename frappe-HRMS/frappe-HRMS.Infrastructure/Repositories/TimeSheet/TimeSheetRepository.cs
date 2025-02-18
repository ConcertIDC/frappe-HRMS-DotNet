using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.TimeSheet;

namespace frappe_HRMS.Infrastructure.Services.TimeSheet
{
    public class TimeSheetRepository : GenericRepository<Domain.TimeSheets.TimeSheet>, ITimeSheetRepository
    {
        public TimeSheetRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
