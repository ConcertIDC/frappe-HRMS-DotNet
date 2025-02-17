using frappe_HRMS.Domain;
using frappe_HRMS.Services.Interfaces;

namespace frappe_HRMS.Services.Services
{
    public class SignupService : GenericService<User>, ISignupService
    {
        public SignupService(Infrastructure.Interfaces.IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
