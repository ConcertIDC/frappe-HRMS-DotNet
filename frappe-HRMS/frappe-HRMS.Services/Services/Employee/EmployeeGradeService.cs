using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Employee;

namespace frappe_HRMS.Services.Services.Employee
{
    public class EmployeeGradeService : GenericService<EmployeeGrade>, IEmployeeGradeService
    {
        public EmployeeGradeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
