using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Employee;
using Microsoft.EntityFrameworkCore;

namespace frappe_HRMS.Services.Services.Employee
{
    public class EmployeeRepository : GenericRepository<Domain.Employee.Employee>, IEmployeeRepository
    {
        public EmployeeRepository(HRMSDbContext context) : base(context)
        {
        }
        public async Task<List<Domain.Employee.Employee>> GetAllEmployees()
        {
            return await _context.Employee.Include(e => e.Company)
                .Include(e => e.Designation)
                .Include(e => e.Branch)
                .Include(e => e.EmplyeeJoiningDetails)
                .Include(e => e.User)
                .Include(e => e.EmployeeGrade)
                .Include(e => e.EmploymentType)
                .Include(e => e.EmployeeAddress)
                .Include(e => e.Designation)
                .Include(e => e.EmployeeSalary).ThenInclude(s => s.CostCenter)
                .Include(e => e.Personal)
                .Include(e => e.Profile)
                     .ThenInclude(p => p.EducationalQualification)
                .Include(e => e.Profile)
                    .ThenInclude(p => p.PreviousWorkExperience)
                .Include(e => e.Profile)
                    .ThenInclude(p => p.EmployeeHistory)
                .Include(e => e.Exit)
                .ToListAsync();
        }

        public Domain.Employee.Employee? GetEmployeeById(int id)
        {
            return  GetAllEmployees().Result.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
