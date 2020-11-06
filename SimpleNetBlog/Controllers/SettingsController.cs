using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Internal.Account;
using Microsoft.AspNetCore.Mvc;
using SimpleNetBlog.Models;
using SimpleNetBlog.ViewModels;

namespace SimpleNetBlog.Controllers
{
    
    [Authorize]
    public class SettingsController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public SettingsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            var viewModel = new ProfileViewModel
            {
                DisplayName = user.DisplayName,
                EmailAddress = user.Email
            };
            return View(viewModel);
        }
        
        [HttpPost]
        public async Task<IActionResult> Profile(ProfileViewModel vm)
        {
            var user = await _userManager.GetUserAsync(User);
    
            if (user.DisplayName != vm.DisplayName)
            {
                user.DisplayName = vm.DisplayName;
            }

            if (user.Email != vm.EmailAddress)
            {
                var token = await _userManager.GenerateChangeEmailTokenAsync(user, vm.EmailAddress);
                var result = await _userManager.ChangeEmailAsync(user, vm.EmailAddress, token);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("","Email change has failed");
                }
            }

            await _userManager.UpdateAsync(user);
            await _signInManager.RefreshSignInAsync(user);
            TempData["Success"] = "Your changes have been saved.";
            return RedirectToAction("Profile", "Settings");
        }
        
        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        } 
        
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("Login", "Account");
                }

                var result = await _userManager.ChangePasswordAsync(user,
                    vm.CurrentPassword, vm.NewPassword);

 
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                }

                await _signInManager.RefreshSignInAsync(user);
                TempData["PwChangeSuccess"] = "Your password has been updated.";
                return View();
            }

            return View(vm);
        }

        
        
    }
}