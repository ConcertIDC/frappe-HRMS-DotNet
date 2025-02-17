namespace frappe_HRMS.Infrastructure.Interfaces.Company
{
    public interface ICompanyRepository : IGenericRepository<Domain.Company.Company>
    {
        Task<List<Domain.Company.Company>> GetAllCompanies();
        List<string?> GetCompanyList();
    }
}
