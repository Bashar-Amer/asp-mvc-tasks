using Microsoft.AspNetCore.Identity;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class UsersSeeder
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersSeeder(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }


        public async Task SeedAdminUserAsync()
        {
            var adminEmail = "admin1@admin.com";
            var adminUser = await _userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    UserName = adminEmail.Split("@")[0],
                    Email = adminEmail,
                    EmailConfirmed = true,
                    Age = 99
                };

                var result = await _userManager.CreateAsync(adminUser, "Password123!");

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                        Console.WriteLine($"Create user error: {error.Code} - {error.Description}");
                    return;
                }
                
                var roleResult = await _userManager.AddToRoleAsync(adminUser, "Admin");
                if (!roleResult.Succeeded)
                {
                    foreach (var error in roleResult.Errors)
                        Console.WriteLine($"Add to role error: {error.Code} - {error.Description}");
                }

            }
        }

    }
}
