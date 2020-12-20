using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfiguration {
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();
            builder.HasIndex(p => p.Name).IsUnique();

            builder
                .Property(p => p.PurchasePrice)
                .HasPrecision(18, 2);

            builder
                .Property(p => p.SalePrice)
                .HasPrecision(18, 2);

            builder
                .Property(p => p.CommissionPercentage)
                .HasPrecision(8, 2);
                
            SeedProduct(builder);
        }

        private static void SeedProduct(EntityTypeBuilder<Product> builder)
        {
            for (var i = 1; i <= 10; i++)
            {
                builder
                    .HasData(
                        new Product
                        {
                            ProductId = i,
                            Name = $"Bike {i}",
                            Manufacturer = $"Manufacturer {i}",
                            Style = $"Style {i}",
                            PurchasePrice = 100.00M * i,
                            SalePrice = 120.00M * i,
                            QuantityOnHand = 10,
                            CommissionPercentage = 2.00M * i
                        }
                    );
            }
        }
    }
}