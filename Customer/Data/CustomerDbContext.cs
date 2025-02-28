using System.Collections.Generic;
using Customer.Models;
using Microsoft.EntityFrameworkCore;

namespace Customer.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) { }
        public DbSet<CustomerModel> Customers { get; set; }
    }
}
