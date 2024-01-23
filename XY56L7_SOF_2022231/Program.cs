using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using XY56L7_SOF_2022231.Data;
using XY56L7_SOF_2022231.Logic;
using XY56L7_SOF_2022231.Logic.Interfaces;
using XY56L7_SOF_2022231.Models;


namespace XY56L7_SOF_2022231
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                
            options.UseSqlServer(connectionString)
                    .UseLazyLoadingProxies()
                );
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<SiteUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

           

            builder.Services.AddControllersWithViews();
            builder.Services.AddAuthentication().AddFacebook(opt =>
            {
                opt.ClientId = "2401614450010109";
                opt.ClientSecret = "0c53d80d8c50c98e852e7dc70eea66fd";
            }
          );
            builder.Services.AddControllersWithViews();

            builder.Services.AddTransient<IEmailSender, EmailSender>();
            builder.Services.AddTransient<ICarLogic, CarLogic>();
            builder.Services.AddTransient<IMotorcycleLogic, MotorcycleLogic>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}