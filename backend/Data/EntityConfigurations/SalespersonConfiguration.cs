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
        }
    }
}