using frappe_HRMS.Domain.Employee;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Employee;

namespace frappe_HRMS.Services.Services.Employee
{
    public class NewJobOpeningService : GenericService<NewJobOpening>, INewJobOpeningService
    {
        public NewJobOpeningService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
