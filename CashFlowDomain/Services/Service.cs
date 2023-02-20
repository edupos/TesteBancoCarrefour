using CashFlow.Domain.Interfaces.Entities;
using CashFlow.Domain.Interfaces.Repositories;
using CashFlow.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Domain.Services
{
    public class Service<T> : IService<T> where T : class, IEntityBase
    {
        private readonly IRepository<T> _repository;
        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public Task<List<T>> GetAll()
        {
            return _repository.GetAll();
        }
        public Task<T> Get(int id)
        {
            return _repository.Get(id);
        }
        public Task<T> Add(T entity)
        {
            return _repository.Add(entity);
        }
        public Task<T> Update(T entity)
        {
            return _repository.Update(entity);
        }
        public Task<T> Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
