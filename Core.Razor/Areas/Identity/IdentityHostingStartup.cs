using System;
using Core.Razor.Areas.Identity.Data;
using Core.Razor.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Core.Razor.Areas.Identity.IdentityHostingStartup))]
namespace Core.Razor.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CoreRaZorContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("CoreRaZorContext")));

                services.AddDefaultIdentity<CoreRazorUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<CoreRaZorContext>();
            });
        }
    }
}