using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Services.Interfaces;

namespace frappe_HRMS.Services.Services.Employee
{
    public interface IEmployeePersonalRepository : IGenericRepository<PersonalDetails>
    {
    }
}
