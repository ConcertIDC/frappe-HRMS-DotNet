using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Services.Services.Employee
{
    public class EmployeeJoiningRepository : GenericRepository<EmplyeeJoiningDetails>, IEmployeeJoiningRepository
    {
        public EmployeeJoiningRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
