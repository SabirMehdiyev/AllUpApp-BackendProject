using AllUpApp_BackendProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AllUpApp_BackendProject.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
             
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            string AdminId = Guid.NewGuid().ToString();
            string AdminRoleId = Guid.NewGuid().ToString();
            string SuperAdminId = Guid.NewGuid().ToString();
            string SuperAdminRoleId = Guid.NewGuid().ToString();
            string UserRoleId = Guid.NewGuid().ToString();
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = AdminRoleId,
                ConcurrencyStamp = AdminRoleId
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN",
                Id = SuperAdminRoleId,
                ConcurrencyStamp = SuperAdminRoleId
            });
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER",
                Id = UserRoleId,
                ConcurrencyStamp = UserRoleId
            });

            var Admin = new AppUser
            {
                Id = AdminId,
                Email = "sabir@gmail.com",
                UserName = "Sabir1",
                FullName = "SabirMehdiyev",
                NormalizedUserName = "SABIR1",
                NormalizedEmail = "SABIR@GMAIL.COM",
                EmailConfirmed = true

            };

            PasswordHasher<AppUser> passwordHash = new PasswordHasher<AppUser>();
            Admin.PasswordHash = passwordHash.HashPassword(Admin, "12345@Ss");
            builder.Entity<AppUser>().HasData(Admin);

            var SuperAdmin = new AppUser
            {
                Id = SuperAdminId,
                UserName = "Sabircode",
                FullName = "SabirMehdi",
                Email = "sabirsm@code.edu.az",
                NormalizedEmail = "SABIRSM@CODE.EDU.AZ",
                NormalizedUserName = "SABIRCODE",
            };

            SuperAdmin.PasswordHash = passwordHash.HashPassword(SuperAdmin, "12345@Ss");
            builder.Entity<AppUser>().HasData(SuperAdmin);
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { UserId = AdminId, RoleId = AdminRoleId });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { UserId = SuperAdminId, RoleId = SuperAdminRoleId });

            base.OnModelCreating(builder);
        }

    }
}
