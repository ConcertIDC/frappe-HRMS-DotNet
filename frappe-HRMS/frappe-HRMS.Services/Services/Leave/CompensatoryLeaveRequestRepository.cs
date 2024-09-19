using frappe_HRMS.Domain.Leave;
using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Services.Interfaces;
using frappe_HRMS.Services.Interfaces.Leave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Services.Services.Leave
{
    public class CompensatoryLeaveRequestRepository : GenericRepository<CompensatoryLeaveRequest>, ICompensatoryLeaveRequestRepository
    {
        public CompensatoryLeaveRequestRepository(HRMSDbContext context) : base(context)
        {
        }
    }
}
