using AllUpApp_BackendProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AllUpApp_BackendProject.Controllers
{
    public class AboutController:Controller
    {
       private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View( _context.Settings.Where(s => !s.IsDeleted).ToDictionary(s => s.Key , s => s.Value));
        }
    }
}
