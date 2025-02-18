using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.Employee;

namespace frappe_HRMS.Infrastructure.Services.Employee
{
    public class EmployeeGradeRepository : GenericRepository<EmployeeGrade>, IEmployeeGradeRepository
    {
        public EmployeeGradeRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
