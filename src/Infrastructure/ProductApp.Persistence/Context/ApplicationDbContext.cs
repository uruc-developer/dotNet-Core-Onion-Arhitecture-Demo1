using Microsoft.EntityFrameworkCore;
using ProductApp.Domain.Entities;
using System;

namespace ProductApp.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name = "Book1", Value = 10, Quantity=100},
                new Product() { Id = Guid.NewGuid(), Name = "Paper", Value = 1, Quantity = 300 },
                new Product() { Id = Guid.NewGuid(), Name = "Pen", Value = 15, Quantity = 120 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
