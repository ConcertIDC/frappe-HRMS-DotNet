using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.Employee;

namespace frappe_HRMS.Infrastructure.Services.Employee
{
    public class PreviousWorkExperienceRepository : GenericRepository<PreviousWorkExperience>, IPreviousWorkExperienceRepository
    {
        public PreviousWorkExperienceRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
