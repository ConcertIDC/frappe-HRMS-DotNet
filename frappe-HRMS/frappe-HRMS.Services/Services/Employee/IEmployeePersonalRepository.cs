using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Services.Services.Employee
{
    public interface IEmployeePersonalRepository : IGenericRepository<PersonalDetails>
    {
    }
}
