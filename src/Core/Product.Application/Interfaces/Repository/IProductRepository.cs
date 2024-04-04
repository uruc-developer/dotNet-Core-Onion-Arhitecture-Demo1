using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Domain.Entities;

namespace ProductApp.Application.Interfaces.Repository
{
    // without generic repository
    //public interface IProductRepository
    //{
    //    Task<List<Product>> GetAllProduct();
    //    Task<Product> GetProductById(Guid Id);
    //}

    public interface IProductRepository : IGenericRepositoryAsync<Product>
    {

    }
}
