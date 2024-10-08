using frappe_HRMS.Domain.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Services.Interfaces.Employee
{
    public interface IEmployeeAttendanceRepository : IGenericRepository<EmployeeAttendanceLeaves>
    {
    }
}
