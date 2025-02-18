using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.Projects;

namespace frappe_HRMS.Infrastructure.Services.Projects
{
    public class TaskRepository : GenericRepository<Domain.Projects.Task>, ITaskRepository
    {
        public TaskRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
