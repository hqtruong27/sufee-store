using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using SS.Services.Interface.IProductServices;
using SS.Services.Services.ProductServices;
using SS.DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using SS.Services.Interface.IUserServices;
using SS.Services.Services.UserServices;
using SS.DataAccess.EF;
using Microsoft.EntityFrameworkCore;
using SS.Utilities.Constants;

namespace SS.Core.DI
{
    public static class DIConfiguration
    {
        public static void RegisterDI(this IServiceCollection services, IConfiguration configuraion)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuraion.GetConnectionString(SystemConstants.NameConnectionString)));
            services.AddIdentity<AppUser, IdentityRole>().
                AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            //
            services.AddTransient<IClientProduct, ClientProductServices>();
            services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<RoleManager<IdentityRole>, RoleManager<IdentityRole>>();
            services.AddTransient<IUserServices, UserSevices>();
        }
    }
}
