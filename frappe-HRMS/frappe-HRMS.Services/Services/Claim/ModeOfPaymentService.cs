using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Claim;

namespace frappe_HRMS.Services.Services.Claim
{
    public class ModeOfPaymentService : GenericService<ModeOfPayment>, IModeOfPaymentService
    {
        public ModeOfPaymentService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
