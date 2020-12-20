using System;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfiguration {
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder
                .Property(d => d.DiscountPercentage)
                .HasPrecision(8, 2);

            SeedDiscount(builder);
        }

        private static void SeedDiscount(EntityTypeBuilder<Discount> builder)
        {
            for (var i = 1; i <= 10; i++)
            {
                builder
                    .HasData(
                        new Discount
                        {
                            DiscountId = i,
                            ProductId = i,
                            BeginDate = DateTimeOffset.Now - TimeSpan.FromDays(10),
                            DiscountPercentage = 15.00M
                        }
                    );
            }
        }
    }
}