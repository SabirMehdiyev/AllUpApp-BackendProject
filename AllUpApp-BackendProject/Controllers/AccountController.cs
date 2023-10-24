using AllUpApp_BackendProject.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace AllUpApp_BackendProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterVM registerVM)
        {
            return View();
        }
    }
}
