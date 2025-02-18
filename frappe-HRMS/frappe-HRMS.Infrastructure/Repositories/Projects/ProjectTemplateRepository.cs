using frappe_HRMS.Domain.Projects;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.Projects;

namespace frappe_HRMS.Infrastructure.Services.Projects
{
    public class ProjectTemplateRepository : GenericRepository<ProjectTemplate>, IProjectTemplateRepository
    {
        public ProjectTemplateRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
