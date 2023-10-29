using Microsoft.AspNetCore.Mvc;

namespace AllUpApp_BackendProject.ViewComponents
{
    public class BrandsFeaturesViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult>InvokeAsync()
        {
            return View();
        }
    }
}
