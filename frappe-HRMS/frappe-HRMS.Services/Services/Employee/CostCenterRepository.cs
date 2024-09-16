using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Employee;

namespace frappe_HRMS.Services.Services.Employee
{
    public class CostCenterRepository : GenericRepository<CostCenter>, ICostCenterRepository
    {
        public CostCenterRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
