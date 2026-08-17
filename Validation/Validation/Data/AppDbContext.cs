using Microsoft.EntityFrameworkCore;
using Validation.Models;

namespace Validation.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Validation.Models.Employee> Employee { get; set; } = default!;
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
