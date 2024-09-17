using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Employee;

namespace frappe_HRMS.Services.Services.Employee
{
    public class EducationalQualificationRepository : GenericRepository<EducationalQualification>, IEducationalQualificationRepository
    {
        public EducationalQualificationRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
