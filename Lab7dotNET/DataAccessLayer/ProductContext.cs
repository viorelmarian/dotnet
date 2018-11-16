using System.Data.Entity;

namespace DataAccessLayer
{
    class ProductContext : DbContext
    {
        public ProductContext() : base("ProductContext")
        {
            Database.CreateIfNotExists();
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().Property(t => t.IsCompleted).IsRequired();
            modelBuilder.Entity<Todo>().Property(t => t.Description).IsRequired().HasMaxLength(50);
        }
    }
}
