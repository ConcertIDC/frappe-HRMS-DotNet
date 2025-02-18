using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Projects;

namespace frappe_HRMS.Services.Services.Projects
{
    public class TaskService : GenericService<Domain.Projects.Task>, ITaskService
    {
        public TaskService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
