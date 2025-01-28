using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FSD_Project.Domain;
using FSD_Project.Configurations.Entities;

namespace FSD_Project.Data
{
    public class FSD_ProjectContext : IdentityDbContext<FSD_ProjectUser>
    {
        public FSD_ProjectContext(DbContextOptions<FSD_ProjectContext> options)
            : base(options)
        {
        }

        // Define DbSets for your entities
        public DbSet<Branch> Branch { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;
        public DbSet<Reservation> Reservation { get; set; } = default!;
        public DbSet<Staff> Staff { get; set; } = default!;
        public DbSet<Table> Table { get; set; } = default!;
        public DbSet<Review> Reviews { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Apply seed data configurations
            builder.ApplyConfiguration(new BranchSeed());
            builder.ApplyConfiguration(new CustomerSeed());
            builder.ApplyConfiguration(new ReservationSeed());
            builder.ApplyConfiguration(new StaffSeed());
            builder.ApplyConfiguration(new TableSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new ReviewSeed());

            // Configure relationships
            builder.Entity<Customer>()
                .HasOne(c => c.User)
                .WithMany() // FSD_ProjectUser does not need a collection for Customers
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes

            builder.Entity<Staff>()
                .HasOne(s => s.User)
                .WithMany() // FSD_ProjectUser does not need a collection for Staff
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes
        }


    }
}
