using frappe_HRMS.Infrastructure.Context;
using frappe_HRMS.Infrastructure.Interfaces;
using frappe_HRMS.Infrastructure.Repositories;
using frappe_HRMS.Services.Interfaces.Company;
using Microsoft.EntityFrameworkCore;

namespace frappe_HRMS.Services.Services.Company
{
    public class CompanyService : GenericService<Domain.Company.Company>, ICompanyService
    {
        public CompanyService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<List<Domain.Company.Company>> GetAllCompanies()
        {
            return await _unitOfWork.Company.GetAllCompanies();
        }

        public List<string?> GetCompanyList()
        {
            return  _unitOfWork.Company.GetCompanyList();
        }

        public async Task<Domain.Company.Company> SetupOrganisation(Domain.Company.Company company)
        {
            var result = await AddAsync(company);

            if (company.IsDemo)
            {
                var demoCompany = new Domain.Company.Company
                {
                    CompanyName = $"{company.CompanyName} (Demo)",
                    CompanyAbbrevation = $"{company.CompanyAbbrevation}D",
                    FinancialYearBeginsOn = company.FinancialYearBeginsOn,
                    IsDemo = false,
                    Currency = company.Currency,
                    Country = company.Country,
                    Designation = company.Designation,
                    TimeZone = company.TimeZone,
                    PhoneNumber = company.PhoneNumber,
                    Industry = company.Industry,
                    NumberOfEmployess = company.NumberOfEmployess,
                    Language = company.Language
                };

                await AddAsync(demoCompany);
            }
            return result;
        }
    }
}
