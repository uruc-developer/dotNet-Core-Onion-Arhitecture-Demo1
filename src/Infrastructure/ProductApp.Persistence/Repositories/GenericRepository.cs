using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepositoryAsync<T> where T : BaseEntity
    {
        public System.Threading.Tasks.Task<T> AddAsync(T Entity)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<T> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
