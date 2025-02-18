using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Employee;

namespace frappe_HRMS.Services.Services.Employee
{
    public class EmployeeGroupService : GenericService<EmployeeGroup>, IEmployeeGroupService
    {
        public EmployeeGroupService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
