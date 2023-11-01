using AllUpApp_BackendProject.DAL;
using AllUpApp_BackendProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            homeVM.Categories = _appDbContext.Categories.Where(c => !c.IsDeleted).ToList();
            homeVM.Products = _appDbContext.Products
                .Include(p => p.ProductTags)
                .Include(p => p.Category)
                .Where(p => !p.IsDeleted)
                .ToList();
            return View(homeVM);
        }   
    }
}