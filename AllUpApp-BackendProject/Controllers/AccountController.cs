using AllUpApp_BackendProject.Helpers;
using AllUpApp_BackendProject.Models;
using AllUpApp_BackendProject.Services;
using AllUpApp_BackendProject.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AllUpApp_BackendProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;


        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, IEmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _emailService = emailService;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = new AppUser();

            user.Email = registerVM.Email;
            user.FullName = registerVM.FullName;
            user.UserName = registerVM.UserName;
            user.IsActive = true;


            IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerVM);
            }

            await _userManager.AddToRoleAsync(user, Roles.User.ToString());

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var link = Url.Action(nameof(VerifyEmail), "Account", new { token, email = user.Email },
                Request.Scheme, Request.Host.ToString());

            string body = String.Empty;
            using (StreamReader streamReader = new StreamReader("wwwroot/confirmemail/confirmemail.html"))
            {
                body = streamReader.ReadToEnd();
            }
            body = body.Replace("{{link}}", link);
            body = body.Replace("{{name}}", user.UserName);

            await _emailService.SendEmailAsync(user.Email, "Verify Email", body, link, user.UserName);

            return RedirectToAction("Login", "Account");
        }
        public async Task<IActionResult> VerifyEmail(string email, string token)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);

            await _userManager.ConfirmEmailAsync(user, token);
            return RedirectToAction("index", "home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "Home");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM, string? ReturnUrl)
        {
            if (!ModelState.IsValid) return View();
            var user = await _userManager.FindByNameAsync(loginVM.UserNameOrEmail);
            if (user == null)
            {
                user = await _userManager.FindByEmailAsync(loginVM.UserNameOrEmail);
                if (user == null)
                {
                    ModelState.AddModelError("", "something went wrong");
                    return View(loginVM);
                }
            }
            if (!user.IsActive)
            {
                ModelState.AddModelError("", "you are blocked");
                return View(loginVM);
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.RememberMe, true);

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "blockedd");
                return View(loginVM);
            }
            if (!user.EmailConfirmed)
            {
                ModelState.AddModelError("", "Please Verify your account");
                return View();
            }
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "something went wrong");
                return View(loginVM);
            }

            await _signInManager.SignInAsync(user, loginVM.RememberMe);
            if (ReturnUrl != null)
            {
                return Redirect(ReturnUrl);
            }

            return RedirectToAction("index", "home");
        }

        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword(string email)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                ModelState.AddModelError("Email", "Email movcud deyil");
                return View();
            }


            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            var link = Url.Action(nameof(ResetPassword), "Account", new { email = user.Email, token }, Request.Scheme, Request.Host.ToString());

            string body = $"<a href=\"{link}\" target=\"_blank\">Please click here to reset your password</a>";

            await _emailService.SendEmailAsync(user.Email, "Reset Password ", body, link, user.UserName);

            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ResetPassword(string email, string token)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null) return NotFound();
            bool isSuccess = await _userManager.VerifyUserTokenAsync(user, _userManager.Options.Tokens.PasswordResetTokenProvider, "ResetPassword", token);
            if (!isSuccess)
            {
                return RedirectToAction("UsedLink");
            }
            return View();
        }
        public IActionResult UsedLink()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(string email, string token, ResetPasswordVM resetPasswordVM)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(email);
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _userManager.ResetPasswordAsync(appUser, token, resetPasswordVM.Password);
            await _userManager.UpdateSecurityStampAsync(appUser);

            return RedirectToAction("Login", "Account");
        }
    }


}
