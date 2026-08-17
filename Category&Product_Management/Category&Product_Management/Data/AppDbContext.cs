using Microsoft.EntityFrameworkCore;

namespace Category_Product_Management.Models
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
                new Product { Id = 1, Name = "Sushi", ImagePath = "products/food/sushi.jfif", CategoryId=2, Description="A good sushi", Price= 39.99f},
                new Product { Id = 2, Name = "Pizza", ImagePath = "products/food/pizza.jfif", CategoryId = 2, Description= "Amazing vegetables pizza", Price = 5.65f},
                new Product { Id = 3, Name = "TV", ImagePath = "products/electronics/tv.jfif", CategoryId = 1, Description="Smart good big TV", Price= 200.99f},
                new Product { Id = 4, Name = "Phone", ImagePath = "products/electronics/phone.jfif", CategoryId = 1, Description="Fast small powerfull IPhone", Price= 399}
            );
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
