using Microsoft.AspNetCore.Identity;
using InternetBanking.Core.Application.Enums;
using InternetBanking.Infrastructure.Identity.Entities;

namespace InternetBanking.Infrastructure.Identity.Seeds
{
    public static class DefaultBasicUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultUser = new();
            defaultUser.UserName = "customer";
            defaultUser.Email = "customer@localhost.com";
            defaultUser.FirstName = "Customer";
            defaultUser.LastName = "User";
            defaultUser.EmailConfirmed = true;
            defaultUser.PhoneNumberConfirmed = true;

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Us3r*D3f41t3");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Customer.ToString());
                }
            }
        }
    }
}
