using AllUpApp_BackendProject.DAL;
using AllUpApp_BackendProject.Models;
using AllUpApp_BackendProject.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace AllUpApp_BackendProject
{
    public static class ServiceRegistration
    {
        public static void Register(this IServiceCollection services, IConfiguration config)
        {
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromMinutes(10);
            });

            services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireDigit = true;

                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = true;

                options.Lockout.AllowedForNewUsers = true;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                options.Lockout.MaxFailedAccessAttempts = 3;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            services.AddScoped<IEmailService, EmailService>();

        }
    }
}
