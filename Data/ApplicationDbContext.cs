using Microsoft.EntityFrameworkCore;
using PEMBEKALAN.Models;

namespace PEMBEKALAN.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Konfigurasi default untuk UUID
            modelBuilder.Entity<ProductCategory>()
                .Property(p => p.Id)
                .HasDefaultValueSql("gen_random_uuid()");
            modelBuilder.Entity<Customer>()
                .Property(p => p.Id)
                .HasDefaultValueSql("gen_random_uuid()");
        }
    }
}