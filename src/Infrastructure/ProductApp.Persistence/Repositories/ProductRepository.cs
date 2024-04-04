using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task<Product> AddAsync(Product Entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
