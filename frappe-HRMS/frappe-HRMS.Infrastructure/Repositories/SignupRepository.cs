using frappe_HRMS.Domain;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;

namespace frappe_HRMS.Infrastructure.Services
{
    public class SignupRepository : GenericRepository<User>, ISignupRepository
    {
        public SignupRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
