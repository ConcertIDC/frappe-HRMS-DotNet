using frappe_HRMS.Domain.Attendance;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Attendance;

namespace frappe_HRMS.Services.Services.Attendance
{
    public class HolidayListService : GenericService<HolidayList>, IHolidayListService
    {
        public HolidayListService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
