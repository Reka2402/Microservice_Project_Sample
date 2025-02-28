using Microsoft.EntityFrameworkCore;
using Order.Models;

namespace Order.Data
{
   
        public class OrderDbContext : DbContext
        {
            public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }
            public DbSet<OrderModel> Orders{ get; set; }
        }
    
}
