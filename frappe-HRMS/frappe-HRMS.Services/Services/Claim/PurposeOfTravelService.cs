using frappe_HRMS.Domain.Claim;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Claim;

namespace frappe_HRMS.Services.Services.Claim
{
    public class PurposeOfTravelService : GenericService<PurposeOfTravel>, IPurposeOfTravelService
    {
        public PurposeOfTravelService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
