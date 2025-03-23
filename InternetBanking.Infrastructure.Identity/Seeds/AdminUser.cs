using Microsoft.AspNetCore.Identity;
using InternetBanking.Core.Application.Enums;
using InternetBanking.Infrastructure.Identity.Entities;

namespace InternetBanking.Infrastructure.Identity.Seeds
{
    public static class AdminUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser adminUser = new();
            adminUser.UserName = "Admin";
            adminUser.Email = "admin@localhost.com";
            adminUser.FirstName = "Admin";
            adminUser.LastName = "User";
            adminUser.EmailConfirmed = true;
            adminUser.PhoneNumberConfirmed = true;

            if (userManager.Users.All(u => u.Id != adminUser.Id))
            {
                var user = await userManager.FindByEmailAsync(adminUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(adminUser, "Us3r*D3f41t3");
                    await userManager.AddToRoleAsync(adminUser, Roles.Admin.ToString());
                }
            }
        }
    }
}
