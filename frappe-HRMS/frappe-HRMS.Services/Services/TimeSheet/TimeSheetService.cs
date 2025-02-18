using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.TimeSheet;

namespace frappe_HRMS.Services.Services.TimeSheet
{
    public class TimeSheetService : GenericService<Domain.TimeSheets.TimeSheet>, ITimeSheetService
    {
        public TimeSheetService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
