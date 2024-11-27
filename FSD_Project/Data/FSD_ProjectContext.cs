using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FSD_Project.Domain;

namespace FSD_Project.Data
{
    public class FSD_ProjectContext : DbContext
    {
        public FSD_ProjectContext (DbContextOptions<FSD_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<FSD_Project.Domain.Branch> Branch { get; set; } = default!;
        public DbSet<FSD_Project.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<FSD_Project.Domain.Reservation> Reservation { get; set; } = default!;
        public DbSet<FSD_Project.Domain.Staff> Staff { get; set; } = default!;
        public DbSet<FSD_Project.Domain.Table> Table { get; set; } = default!;
    }
}
