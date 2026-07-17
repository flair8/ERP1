using ERP1.Configuration;
using ERP1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ERP1.Data
{
    public sealed class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Address> Addresses {  get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.Property(e => e.Document);
            });

            builder.Entity<Address>()
                .ToTable("Addresses", "dbo");

            builder.Entity<Customer>()
                .ToTable("Customers","dbo");

            builder.ApplyConfiguration(
                new CustomerConfiguration());

            builder.HasDefaultSchema("identity");
        }
    }
}
