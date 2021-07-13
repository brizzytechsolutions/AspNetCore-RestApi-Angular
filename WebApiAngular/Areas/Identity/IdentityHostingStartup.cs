using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApiAngular.Areas.Identity.Data;

[assembly: HostingStartup(typeof(WebApiAngular.Areas.Identity.IdentityHostingStartup))]
namespace WebApiAngular.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebApiAngularContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebApiAngularContextConnection")));

                services.AddDefaultIdentity<WebApiAngularUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<WebApiAngularContext>();
            });
        }
    }
}