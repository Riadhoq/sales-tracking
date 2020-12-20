using Data.EntityConfiguration;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data {
    public class SalesContext: DbContext {
        public SalesContext(DbContextOptions<SalesContext> options): base(options) {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Salesperson> Salespeople { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration());
            modelBuilder.ApplyConfiguration<Salesperson>(new SalespersonConfiguration());
            modelBuilder.ApplyConfiguration<Customer>(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration<Discount>(new DiscountConfiguration());
        }

    }
}
