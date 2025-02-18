namespace frappe_HRMS.Infrastructure.Interfaces.Employee
{
    public interface IEmployeeRepository : IGenericRepository<Domain.Employee.Employee>
    {
        Task<List<Domain.Employee.Employee>> GetAllEmployees();
        Domain.Employee.Employee? GetEmployeeById(int id);
    }
}
