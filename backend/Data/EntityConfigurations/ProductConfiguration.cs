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
                .HasPrecision(18,2);

            builder
                .Property(p => p.SalePrice)
                .HasPrecision(18,2);

            builder
                .Property(p => p.CommissionPercentage)
                .HasPrecision(8,2);
        }
    }
}