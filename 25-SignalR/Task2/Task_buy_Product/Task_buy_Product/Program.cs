using Microsoft.EntityFrameworkCore;
using Task_buy_Product.Hubs;
using Task_buy_Product.Models;

namespace Task_buy_Product
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //DataBase

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<MyContext>(options =>
            options.UseSqlServer(connectionString));
            builder.Services.AddSignalR();
            builder.Services.AddCors(opt => 
                                        opt.AddDefaultPolicy(policy => 
                                         policy.WithOrigins("http://127.0.0.1:5500/").AllowAnyMethod()
                                         .AllowAnyHeader().AllowCredentials()));
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

            app.UseAuthorization();

            app.MapHub<QuantityHub>("QuantityHub");
            app.MapHub<ProductHub>("ProductHub");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}