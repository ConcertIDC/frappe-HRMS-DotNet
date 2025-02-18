using frappe_HRMS.Domain.TimeSheets;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces.TimeSheet;

namespace frappe_HRMS.Infrastructure.Services.TimeSheet
{
    public class BillingDetailsRepository : GenericRepository<BillingDetails>, IBillingDetailsRepository
    {
        public BillingDetailsRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
