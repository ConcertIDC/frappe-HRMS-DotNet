using frappe_HRMS.Domain.Company;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.Company;
using frappe_HRMS.Infrastructure.Services;

namespace frappe_HRMS.Infrastructure.Repositories.Company
{
    internal class DesignationRepository : GenericRepository<Designation>, IDesignationRepository
    {
        public DesignationRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
