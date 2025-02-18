using frappe_HRMS.Domain.Projects;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.Projects;

namespace frappe_HRMS.Infrastructure.Services.Projects
{
    public class ProjectUpdateRepository : GenericRepository<ProjectUpdate>, IProjectUpdateRepository
    {
        public ProjectUpdateRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
