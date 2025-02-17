using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Claim;

namespace frappe_HRMS.Services.Services.Claim
{
    public class TaxesAndChargesService : GenericService<TaxesAndCharges>, ITaxesAndChargesService
    {
        public TaxesAndChargesService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
