using AllUpApp_BackendProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AllUpApp_BackendProject.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
