using AllUpApp_BackendProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AllUpApp_BackendProject.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
