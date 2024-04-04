using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Domain.Common;
using ProductApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductApp.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepositoryAsync<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<T> AddAsync(T Entity)
        {
            await dbContext.Set<T>().AddAsync(Entity);
            await dbContext.SaveChangesAsync();
            return Entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await dbContext.Set<T>().ToListAsync();

        }

        public async Task<T> GetByIdAsync(Guid Id)
        {
            return await dbContext.Set<T>().FindAsync(Id);
        }
    }
}
