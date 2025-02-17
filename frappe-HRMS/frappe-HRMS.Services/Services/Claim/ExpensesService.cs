using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Claim;

namespace frappe_HRMS.Services.Services.Claim
{
    public class ExpensesService : GenericService<Expenses>, IExpensesService
    {
        public ExpensesService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
