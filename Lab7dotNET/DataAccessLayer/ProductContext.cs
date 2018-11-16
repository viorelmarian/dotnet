using Microsoft.EntityFrameworkCore;
namespace DataAccessLayer
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(t => t.Name).IsRequired();
            modelBuilder.Entity<Product>().Property(t => t.Price).IsRequired().HasMaxLength(50);
        }
    }
}
