using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Interfaces;

namespace frappe_HRMS.Services.Services.Employee
{
    public class EmployeePersonalService : GenericService<PersonalDetails>, IEmployeePersonalService
    {
        public EmployeePersonalService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
