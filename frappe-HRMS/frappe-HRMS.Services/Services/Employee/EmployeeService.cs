using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Employee;
using Microsoft.EntityFrameworkCore;

namespace frappe_HRMS.Services.Services.Employee
{
    public class EmployeeService : GenericService<Domain.Employee.Employee>, IEmployeeService
    {
        public EmployeeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<List<Domain.Employee.Employee>> GetAllEmployees()
        {
            return await _unitOfWork.Employee.GetAllEmployees();
        }

        public Domain.Employee.Employee? GetEmployeeById(int id)
        {
            return  GetAllEmployees().Result.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
