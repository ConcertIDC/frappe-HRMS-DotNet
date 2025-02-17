using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Infrastructure.Interfaces.Company;
using frappe_HRMS.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Infrastructure.Repositories.Company
{
    public class CompanyRepository : GenericRepository<Domain.Company.Company>, ICompanyRepository
    {
        public CompanyRepository(HRMSDbContext context) : base(context)
        {
        }
        public async Task<List<Domain.Company.Company>> GetAllCompanies()
        {
            return await _context.Company.Include(c => c.Employees).ToListAsync();
        }

        public List<string?> GetCompanyList()
        {
            return _context.Company.ToList().Select(x => x.CompanyName).ToList();
        }
    }
}
