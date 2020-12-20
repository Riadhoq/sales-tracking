using System;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfiguration {
    public class SalespersonConfiguration : IEntityTypeConfiguration<Salesperson>
    {
        public void Configure(EntityTypeBuilder<Salesperson> builder)
        {
            builder
                .Property(sp => sp.FirstName)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(sp => sp.LastName)
                .HasMaxLength(50)
                .IsRequired();
            builder.HasIndex(sp => new { sp.FirstName, sp.LastName }).IsUnique();
            
            SeedSalesperson(builder);
        }

        private static void SeedSalesperson(EntityTypeBuilder<Salesperson> builder)
        {
            for (var i = 1; i <= 5; i++)
            {
                builder
                    .HasData(
                        new Salesperson
                        {
                            SalespersonId = i,
                            FirstName = $"Mike {i}",
                            LastName = $"Salesperson {i}",
                            Address = $"Salesperson Address {i}",
                            Phone = $"12345{i}",
                            StartDate = DateTimeOffset.Now - TimeSpan.FromDays(i * 45),
                            Manager = "Manager"
                        }
                    );
            }
        }
    }
}