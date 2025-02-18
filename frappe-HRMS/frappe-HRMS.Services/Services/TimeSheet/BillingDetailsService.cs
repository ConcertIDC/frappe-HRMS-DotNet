using frappe_HRMS.Domain.TimeSheets;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.TimeSheet;

namespace frappe_HRMS.Services.Services.TimeSheet
{
    public class BillingDetailsService : GenericService<BillingDetails>, IBillingDetailsService
    {
        public BillingDetailsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
