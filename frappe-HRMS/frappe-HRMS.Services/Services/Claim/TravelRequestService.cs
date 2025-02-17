using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Claim;

namespace frappe_HRMS.Services.Services.Claim
{
    public class TravelRequestService : GenericService<TravelRequest>, ITravelRequestService
    {
        public TravelRequestService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
