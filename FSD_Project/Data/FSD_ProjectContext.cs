using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FSD_Project.Data;
using FSD_Project.Configurations.Entities;

namespace FSD_Project.Data
{
    public class FSD_ProjectContext(DbContextOptions<FSD_ProjectContext> options) : IdentityDbContext<FSD_ProjectUser>(options)
    {
        public DbSet<FSD_Project.Domain.Branch> Branch { get; set; } = default!;
        public DbSet<FSD_Project.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<FSD_Project.Domain.Reservation> Reservation { get; set; } = default!;
        public DbSet<FSD_Project.Domain.Staff> Staff { get; set; } = default!;
        public DbSet<FSD_Project.Domain.Table> Table { get; set; } = default!;
        public DbSet<FSD_Project.Domain.Review> Reviews { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new BranchSeed());
            builder.ApplyConfiguration(new CustomerSeed());
            builder.ApplyConfiguration(new ReservationSeed());
            builder.ApplyConfiguration(new StaffSeed());
            builder.ApplyConfiguration(new TableSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new ReviewSeed());
        }
    }
}