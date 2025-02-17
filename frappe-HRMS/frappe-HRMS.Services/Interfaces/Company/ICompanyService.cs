namespace frappe_HRMS.Services.Interfaces.Company
{
    public interface ICompanyService : IGenericService<Domain.Company.Company>
    {
        Task<List<Domain.Company.Company>> GetAllCompanies();
        List<string?> GetCompanyList();
        Task<Domain.Company.Company> SetupOrganisation(Domain.Company.Company company);
    }   
}
