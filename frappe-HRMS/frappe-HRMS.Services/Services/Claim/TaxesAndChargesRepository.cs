using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces.Claim;

namespace frappe_HRMS.Services.Services.Claim
{
    public class TaxesAndChargesRepository : GenericRepository<TaxesAndCharges>, ITaxesAndChargesRepository
    {
        public TaxesAndChargesRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
