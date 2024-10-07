using frappe_HRMS.Domain.Attendance;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Attendance;

namespace frappe_HRMS.Services.Services.Attendance
{
    public class ShiftTypeRepository : GenericRepository<ShiftType>, IShiftTypeRepository
    {
        public ShiftTypeRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
