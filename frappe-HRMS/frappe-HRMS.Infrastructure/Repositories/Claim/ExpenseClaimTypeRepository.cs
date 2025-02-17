using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.Claim;

namespace frappe_HRMS.Infrastructure.Services.Claim
{
    public class ExpenseClaimTypeRepository : GenericRepository<ExpenseClaimType>, IExpenseClaimTypeRepository
    {
        public ExpenseClaimTypeRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
