using AllUpApp_BackendProject.DAL;
using AllUpApp_BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AllUpApp_BackendProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new();
            homeVM.Sliders = _appDbContext.Sliders.Where(s=>!s.IsDeleted).ToList();
            return View(homeVM);
        }
    }
}