using FSD_Project.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSD_Project.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<FSD_ProjectUser>
    {
        public void Configure(EntityTypeBuilder<FSD_ProjectUser> builder)
        {
            var hasher = new PasswordHasher<FSD_ProjectUser>();

            builder.HasData(
                // Admin User
                new FSD_ProjectUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                // Customer User
                new FSD_ProjectUser
                {
                    Id = "customer1-id",
                    Email = "customer1@example.com",
                    NormalizedEmail = "CUSTOMER1@EXAMPLE.COM",
                    FirstName = "John",
                    LastName = "Doe",
                    UserName = "customer1@example.com",
                    NormalizedUserName = "CUSTOMER1@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "Customer@123"),
                    EmailConfirmed = true
                },
                // Staff User
                new FSD_ProjectUser
                {
                    Id = "staff1-id",
                    Email = "staff1@example.com",
                    NormalizedEmail = "STAFF1@EXAMPLE.COM",
                    FirstName = "Jane",
                    LastName = "Smith",
                    UserName = "staff1@example.com",
                    NormalizedUserName = "STAFF1@EXAMPLE.COM",
                    PasswordHash = hasher.HashPassword(null, "Staff@123"),
                    EmailConfirmed = true
                }
            );
        }
    }
}
