using frappe_HRMS.Domain.TimeSheets;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.TimeSheet;

namespace frappe_HRMS.Services.Services.TimeSheet
{
    public class TimeSheetListService : GenericService<TimeSheetList>, ITimeSheetListService
    {
        public TimeSheetListService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
