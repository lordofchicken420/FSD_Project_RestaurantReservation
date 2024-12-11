using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using FSD_Project.Data;

namespace FSD_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<FSD_ProjectUser> _signInManager;
        private readonly ILogger<AccountController> _logger;

        public AccountController(SignInManager<FSD_ProjectUser> signInManager, ILogger<AccountController> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        // Logout action
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout(string? returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");

            // Send a message to the client (this could be passed through a redirect or another method)
            TempData["LogoutSuccess"] = true;

            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
