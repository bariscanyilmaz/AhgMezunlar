using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AhgMezunlar.Models;
using AhgMezunlar.Models.Abstract;
using AhgMezunlar.Models.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AhgMezunlar
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IAdminRepository, AdminRepository>();
            services.AddTransient<IEventsRepository, EventsRepository>();
            services.AddTransient<IMomentsRepository, MomentsRepository>();
            services.AddTransient<ISliderRepository, SliderRepository>();
            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,UserManager<ApplicationUser> userManager,RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            EnsureRoleAsync(roleManager).Wait();
            EnsureTestAdminAsync(userManager).Wait();
            app.UseStaticFiles();
            app.UseStatusCodePages();

            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Default", template: "{Controller=Home}/{Action=Index}/{Id?}"
                    );
            });
        }

        private static async Task EnsureRoleAsync(RoleManager<IdentityRole> roleManager)
        {
            var alreadyExists = await roleManager.RoleExistsAsync("Admin");

            if (alreadyExists) return;

            await roleManager.CreateAsync(new IdentityRole("Admin"));

        }

        private static async Task EnsureTestAdminAsync(UserManager<ApplicationUser> userManager)
        {
            var testAdmin = await userManager.Users.Where(x => x.UserName == "ylmazbarscan@gmail.com").SingleOrDefaultAsync();

            if (testAdmin != null) return;

            testAdmin = new ApplicationUser { UserName = "ylmazbarscan@gmail.com", Email = "ylmazbarscan@gmail.com" };
            await userManager.CreateAsync(testAdmin, "Y!m@z13ar$C@n");
            await userManager.AddToRoleAsync(testAdmin, "Admin");

        }


    }
}
