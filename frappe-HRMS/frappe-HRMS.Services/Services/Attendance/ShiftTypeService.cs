using frappe_HRMS.Domain.Attendance;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Attendance;

namespace frappe_HRMS.Services.Services.Attendance
{
    public class ShiftTypeService : GenericService<ShiftType>, IShiftTypeService
    {
        public ShiftTypeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
