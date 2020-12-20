using System;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfiguration {
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            SeedSale(builder);
        }

        private static void SeedSale(EntityTypeBuilder<Sale> builder)
        {
            builder.HasData(
                new Sale
                {
                    SaleId = 1,
                    CustomerId = 1,
                    ProductId = 3,
                    SalespersonId = 1,
                    SalesDate = DateTimeOffset.Now - TimeSpan.FromDays(10)
                }
            );

            builder.HasData(
                new Sale
                {
                    SaleId = 2,
                    CustomerId = 2,
                    ProductId = 4,
                    SalespersonId = 2,
                    SalesDate = DateTimeOffset.Now - TimeSpan.FromDays(5)
                }
            );

            builder.HasData(
                new Sale
                {
                    SaleId = 3,
                    CustomerId = 3,
                    ProductId = 5,
                    SalespersonId = 2,
                    SalesDate = DateTimeOffset.Now - TimeSpan.FromDays(15)
                }
            );

            builder.HasData(
                new Sale
                {
                    SaleId = 4,
                    CustomerId = 4,
                    ProductId = 6,
                    SalespersonId = 2,
                    SalesDate = DateTimeOffset.Now - TimeSpan.FromDays(8)
                }
            );
        }
    }
}