using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;
using AngularProject.Models;
using AngularProject.Tools;

namespace AngularProject.Context
{
    public static class DataSeeder
    {
        public static IApplicationBuilder SeedAdminUser(this IApplicationBuilder app)
        {
            using var service = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var angularProjectContext = service.ServiceProvider.GetRequiredService<AngularProjectContext>();
            var userManager = service.ServiceProvider.GetRequiredService<UserManager<User>>();

            var configuration = AppVariableConfiguration.ConfigurationRoot();

            if (angularProjectContext.Users.Any()) return app;

            var user = new User()
            {
                UserName = configuration.GetSection("AdminUser:AdminLogin").Value,
                //Name = configuration.GetSection("AdminUser:AdminName").Value,
                Email = configuration.GetSection("AdminUser:AdminEmail").Value
            };
            var userTask = userManager.CreateAsync(user, configuration.GetSection("AdminUser:AdminPassword").Value);
            Task.WaitAll(userTask);

            var roleTask = userManager.AddToRoleAsync(user, "admin");
            Task.WaitAll(roleTask);
            return app;
        }
    }
}
