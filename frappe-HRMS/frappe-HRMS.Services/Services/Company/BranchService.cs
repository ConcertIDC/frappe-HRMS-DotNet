using frappe_HRMS.Domain.Company;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Infrastructure.Repositories.Company;
using frappe_HRMS.Services.Interfaces.Company;

namespace frappe_HRMS.Services.Services.Company
{
    public class BranchService : GenericService<Branch>, IBranchService
    {
        public BranchService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
