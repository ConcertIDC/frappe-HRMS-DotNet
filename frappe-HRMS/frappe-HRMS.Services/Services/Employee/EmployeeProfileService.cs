using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Services.Services.Employee
{
    public class EmployeeProfileService : GenericService<EmployeeProfile>, IEmployeeProfileService
    {
        public EmployeeProfileService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
