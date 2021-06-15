using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.coreidentity.core.Models;

namespace test.coreidentity.core.Data
{
    public static class ContextSeed
    {
        public const string ROLE_NAME = "regular";

        public static async Task SeedDefaultRole(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed
            await roleManager.CreateAsync(new IdentityRole(ROLE_NAME));
        }

        public static async Task SeedDefaultUser(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new IdentityUser
            {
                UserName = "admin",
                Email = "admin@fake.email.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "Password.123");
                    await userManager.AddToRoleAsync(defaultUser, ROLE_NAME);
                }

            }
        }
    }
}
