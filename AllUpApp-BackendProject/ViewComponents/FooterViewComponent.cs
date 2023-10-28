using AllUpApp_BackendProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AllUpApp_BackendProject.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var setting = _context.Settings.ToDictionary(s => s.Key, s => s.Value);
            return View(await Task.FromResult(setting));
        }
    }
}
