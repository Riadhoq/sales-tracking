using System;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfiguration {
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .Property(p => p.FirstName)
                .HasMaxLength(25)
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .HasMaxLength(25)
                .IsRequired();
            
            SeedCustomer(builder);
        }

        private static void SeedCustomer(EntityTypeBuilder<Customer> builder)
        {
            for (var i = 1; i <= 5; i++)
            {
                builder
                    .HasData(
                        new Customer
                        {
                            CustomerId = i,
                            FirstName = $"John {i}",
                            LastName = $"Doe {i}",
                            Address = $"Customer Address {i}",
                            Phone = $"54321{i}",
                            StartDate = DateTimeOffset.Now - TimeSpan.FromDays(i * 20)
                        }
                    );
            }
        }
    }
}