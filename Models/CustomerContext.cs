using BasicApi.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> TodoItems { get; set; }
    }
}