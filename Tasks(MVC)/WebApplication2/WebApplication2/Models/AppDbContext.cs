using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electornics",ImagePath="categories/electronics.jfif" },
                new Category { Id = 2, Name = "Food",ImagePath="categories/food.jfif" }
            );

            builder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Sushi", ImagePath = "products/food/sushi.jfif", CategoryId=2 },
                new Product { Id = 2, Name = "Pizza", ImagePath = "products/food/pizza.jfif", CategoryId = 2 },
                new Product { Id = 3, Name = "TV", ImagePath = "products/electronics/tv.jfif", CategoryId = 1 },
                new Product { Id = 4, Name = "Phone", ImagePath = "products/electronics/phone.jfif", CategoryId = 1 }
            );
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
