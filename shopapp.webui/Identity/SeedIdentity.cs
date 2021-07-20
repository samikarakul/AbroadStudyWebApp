using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace shopapp.webui.Identity
{
    public class SeedIdentity
    {
        public static async Task Seed(UserManager<User> userManager, RoleManager<IdentityRole> roleManager,IConfiguration configuration)
        {
            var username=configuration["Data:AdminUser:username"];
            var password=configuration["Data:AdminUser:password"];
            var role=configuration["Data:AdminUser:role"];
            if(await userManager.FindByNameAsync(username)==null)
            {
                await roleManager.CreateAsync(new IdentityRole(role));
                var user = new User()
                {
                    UserName = username,
                    FirstName = "admin",
                    LastName = "admin",
                };
                var result = await userManager.CreateAsync(user,password);
                if(result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user,role);
                }
            }
        }
    }
}