namespace frappe_HRMS.Services.Interfaces.Employee
{
    public interface IEmployeeService : IGenericService<Domain.Employee.Employee>
    {
        Task<List<Domain.Employee.Employee>> GetAllEmployees();
        Domain.Employee.Employee? GetEmployeeById(int id);
    }
}
