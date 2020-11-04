using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SimpleNetBlog.ViewModels;

namespace SimpleNetBlog.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<IdentityUser> _signInManager;

        public AccountController(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }
        
        [HttpGet]
        public IActionResult Login(string userName = "")
        {
            return View(new LoginViewModel { UserName = userName});
        }
        
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Panel");
                }
            }
            else
            {
                ModelState.AddModelError("invalid", "Invalid attempt.");
            }

            return View(loginViewModel);
        }
        
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        
    }
}