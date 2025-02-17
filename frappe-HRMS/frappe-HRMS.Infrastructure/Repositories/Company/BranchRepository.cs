using frappe_HRMS.Domain.Company;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.Company;
using frappe_HRMS.Infrastructure.Services;

namespace frappe_HRMS.Infrastructure.Repositories.Company
{
    public class BranchRepository : GenericRepository<Branch>, IBranchRepository
    {
        public BranchRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
