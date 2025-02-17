using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Claim;

namespace frappe_HRMS.Services.Services.Claim
{
    public class ExpenseClaimTypeService : GenericService<ExpenseClaimType>, IExpenseClaimTypeService
    {
        public ExpenseClaimTypeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
