using ERP1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERP1.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(x => x.FullName)
               .HasMaxLength(200)
               .IsRequired();

            builder.OwnsOne(x => x.Document, cpf =>
            {
                cpf.Property(x => x.Number)
                    .HasColumnName("Cpf")
                   .HasMaxLength(11)
                   .IsRequired();
            });

            builder.OwnsOne(x => x.Email);

            builder.OwnsOne(x => x.Phone);

            builder.HasMany(x => x.Addresses)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);
        }
    }
}
