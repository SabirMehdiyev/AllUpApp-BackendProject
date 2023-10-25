using Microsoft.AspNetCore.Identity;

namespace AllUpApp_BackendProject.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public bool IsActive { get; set; }

    }
}
