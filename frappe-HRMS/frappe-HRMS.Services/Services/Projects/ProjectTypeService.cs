using frappe_HRMS.Domain.Projects;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Projects;

namespace frappe_HRMS.Services.Services.Projects
{
    public class ProjectTypeService : GenericService<ProjectType>, IProjectTypeService
    {
        public ProjectTypeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
