using frappe_HRMS.Domain.Attendance;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.Attendance;

namespace frappe_HRMS.Infrastructure.Services.Attendance
{
    public class HolidayListRepository : GenericRepository<HolidayList>, IHolidayListRepository
    {
        public HolidayListRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
