using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Domain.Entities;

namespace ProductApp.Application.Interfaces.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProduct();
    }
}
