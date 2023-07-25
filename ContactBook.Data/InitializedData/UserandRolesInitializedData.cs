using ContactBook.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Data.InitializedData
{
    public class UserandRolesInitializedData
    {
        public static async Task SeedData(ContactBookContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            context.Database.EnsureCreated();
            await SeedRoles(roleManager);
            await SeedUsers(userManager);
        }

        private static async Task SeedUsers(UserManager<AppUser> userManager)
        {
            if(userManager.FindByEmailAsync())
        }

        private static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {

            if(roleManager.RoleExistsAsync("Admin").Result == false)
            {
                var role = new IdentityRole
                {
                    Name = "Admin"
                };

                await roleManager.CreateAsync(role);
            }
        }
    }
}
