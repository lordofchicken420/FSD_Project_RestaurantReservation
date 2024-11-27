using Microsoft.AspNetCore.Identity;

namespace FSD_Project.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class FSD_ProjectUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
