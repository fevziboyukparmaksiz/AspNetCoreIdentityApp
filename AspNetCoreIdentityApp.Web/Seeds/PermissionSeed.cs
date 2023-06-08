using AspNetCoreIdentityApp.Web.Models;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json.Linq;
using System.Security.Claims;

namespace AspNetCoreIdentityApp.Web.Seeds
{
    public static class PermissionSeed
    {
        public async static Task Seed(RoleManager<AppRole> roleManager)
        {
            var hasBasicRole = await roleManager.RoleExistsAsync("BasicROle");

            if (!hasBasicRole)
            {
                await roleManager.CreateAsync(new AppRole() { Name = "BasicRole" });

                var basicRole = await roleManager.FindByNameAsync("BasicRole");

                await roleManager.AddClaimAsync(basicRole, new Claim("Permission", PermissionsRoot.Permissions.Stock.Read));

                await roleManager.AddClaimAsync(basicRole, new Claim("Permission", PermissionsRoot.Permissions.Order.Read));

                await roleManager.AddClaimAsync(basicRole, new Claim("Permission", PermissionsRoot.Permissions.Catalog.Read));

            }

        }
    }
}
