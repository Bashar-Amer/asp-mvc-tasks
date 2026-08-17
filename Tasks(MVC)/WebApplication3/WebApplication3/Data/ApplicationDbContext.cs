using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "e87f16bc-4933-4f5b-b9d9-2e06180dfa21",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "e87f16bc-4933-4f5b-b9d9-2e06180dfa21"
                },
                new IdentityRole
                {
                    Id = "3c69946d-c4f6-45ce-9648-ef12e0468676",
                    Name = "User",
                    NormalizedName = "USER",
                    ConcurrencyStamp = "3c69946d-c4f6-45ce-9648-ef12e0468676"
                }
            );
        }
    }
}
