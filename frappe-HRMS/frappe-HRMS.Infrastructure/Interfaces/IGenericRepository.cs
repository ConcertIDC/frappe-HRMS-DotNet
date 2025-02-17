using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frappe_HRMS.Infrastructure.Interfaces
{
    public interface IGenericRepository <T> where T : class
    {
        Task<List<T>> GetAll();
        T GetById(int entity);
        T Update(T entity);
        Task<T> AddAsync(T entity);
        Task Delete(int Entity);
    }
}
