using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Context;

namespace frappe_HRMS.Services.Services.Employee
{
    public class EmployeePersonalRepository : GenericRepository<PersonalDetails>, IEmployeePersonalRepository
    {
        public EmployeePersonalRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
