using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSD_Project.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                // Admin Role Assignment
                new IdentityUserRole<string>
                {
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4", // Admin User
                    RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba"  // Admin Role
                },
                // Customer Role Assignment
                new IdentityUserRole<string>
                {
                    UserId = "customer1-id", // Customer User
                    RoleId = "customer-role-id" // Customer Role
                },
                // Staff Role Assignment
                new IdentityUserRole<string>
                {
                    UserId = "staff1-id", // Staff User
                    RoleId = "staff-role-id" // Staff Role
                }
            );
        }
    }
}
