using frappe_HRMS.Domain.Base;
using frappe_HRMS.Infrastructure.Interfaces;
using System.Linq.Expressions;

namespace frappe_HRMS.Services.Services
{
    public class GenericService<T> : Interfaces.IGenericService<T> where T : BaseEntity
    {
        protected IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<T> _repository;

        public GenericService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<T>();
        }

        public async Task<List<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<T> Update(T entity)
        {
            _repository.Update(entity);
            await _unitOfWork.Save();
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.Save();
            return entity;
        }

        public async Task Delete(int entityId)
        {
            var entity =  _repository.GetById(entityId);
            if (entity != null)
            {
                await _repository.Delete(entity.Id);
                await _unitOfWork.Save();
            }
        }

        public T GetById(int entity)
        {
            return _repository.GetById(entity);
        }
    }
}
