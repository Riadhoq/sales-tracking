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
        }
    }
}