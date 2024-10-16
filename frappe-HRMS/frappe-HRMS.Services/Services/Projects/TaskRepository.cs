using frappe_HRMS.Domain.Projects;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Services.Services.Projects
{
    public class TaskRepository : GenericRepository<Domain.Projects.Task>, ITaskRepository
    {
        public TaskRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
