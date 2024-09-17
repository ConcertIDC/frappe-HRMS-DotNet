using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Employee;

namespace frappe_HRMS.Services.Services.Employee
{
    public class PreviousWorkExperienceRepository : GenericRepository<PreviousWorkExperience>, IPreviousWorkExperienceRepository
    {
        public PreviousWorkExperienceRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
