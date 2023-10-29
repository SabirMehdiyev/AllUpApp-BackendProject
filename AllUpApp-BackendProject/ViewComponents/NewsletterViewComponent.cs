using AllUpApp_BackendProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AllUpApp_BackendProject.ViewComponents
{
    public class NewsletterViewComponent:ViewComponent
    {
            public async Task<IViewComponentResult> InvokeAsync()
            {
                return View();
            }
    }
}
