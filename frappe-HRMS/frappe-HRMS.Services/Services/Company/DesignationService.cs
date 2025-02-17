using frappe_HRMS.Domain.Company;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Services.Interfaces.Company;

namespace frappe_HRMS.Services.Services.Company
{
    public class DesignationService : GenericService<Designation>, IDesignationService
    {
        public DesignationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
