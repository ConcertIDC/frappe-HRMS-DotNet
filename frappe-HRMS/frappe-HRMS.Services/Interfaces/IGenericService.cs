

using frappe_HRMS.Domain.Base;

namespace frappe_HRMS.Services.Interfaces
{
    public interface IGenericService<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        T GetById(int entity);
        Task<T> Update(T entity);
        Task<T> AddAsync(T entity);
        Task Delete(int Entity);
    }
}
