using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.Employee;

namespace frappe_HRMS.Infrastructure.Services.Employee
{
    public class NewJobApplicantRepository : GenericRepository<NewJobApplicant>, INewJobApplicantRepository
    {
        public NewJobApplicantRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
