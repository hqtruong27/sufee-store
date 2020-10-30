using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SS.DataAccess.EF;
using SS.DataAccess.Entities;
using SS.Services.Interface.IProductServices;
using SS.Services.Interface.IUserServices;
using SS.Services.Services.ProductServices;
using SS.Services.Services.UserServices;
using SS.Utilities.Constants;
using SS.WebAPI.Models;

namespace SS.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString(SystemConstants.NameConnectionString)));
            services.AddIdentity<AppUser, IdentityRole>().
                AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            //DI Inject
            services.AddTransient<IClientProduct, ClientProductServices>();
            services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddTransient<RoleManager<IdentityRole>, RoleManager<IdentityRole>>();
            services.AddTransient<IUserServices, UserSevices>();

            services.AddControllers();

            //Swagger + Jwt Bearer
            services.ConfigureAuthentication(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            //Authen before Authorize
            app.UseAuthentication();

            app.UseAuthorization();

            //swagger
            app.UseSwagger();

            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger Sufee_Store_v1");
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
