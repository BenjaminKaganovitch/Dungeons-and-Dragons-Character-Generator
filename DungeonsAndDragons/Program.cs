//using DungeonsAndDragons.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using DungeonsAndDragons.Identity;
using DungeonsAndDragons.DataAccess;

namespace DungeonsAndDragons
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            //Injecting connection string class, into the application DbContext Class
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("DungeonsAndDragons")));
            builder.Services.AddDefaultIdentity<UserLeadEntity>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
                        app.UseAuthentication();;

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}