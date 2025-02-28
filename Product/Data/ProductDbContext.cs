using Microsoft.EntityFrameworkCore;
using Product.Models;

namespace Product.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
        public DbSet<ProductModel> Products { get; set; }
    }
}
