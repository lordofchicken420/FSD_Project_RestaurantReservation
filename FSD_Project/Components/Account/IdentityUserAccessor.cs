using FSD_Project.Data;
using Microsoft.AspNetCore.Identity;

namespace FSD_Project.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<FSD_ProjectUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<FSD_ProjectUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
