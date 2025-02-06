using Microsoft.EntityFrameworkCore;
using FSD_Project.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSD_Project.Configurations.Entities
{
    public class TableSeed : IEntityTypeConfiguration<Table>
    {
        public void Configure(EntityTypeBuilder<Table> builder)
        {
            builder.HasData(
                new Table
                {
                    Id = 1,
                    Capacity = 10,
                    Status = true,
                    BranchId = 1,  

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Table
                {
                    Id = 2,
                    Capacity = 10,
                    Status = true,
                    BranchId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Table
                {
                    Id = 3,
                    Capacity = 10,
                    Status = true,
                    BranchId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Table
                {
                    Id = 4,
                    Capacity = 10,
                    Status = true,
                    BranchId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Table
                {
                    Id = 5,
                    Capacity = 10,
                    Status = true,
                    BranchId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Table
                {
                    Id = 6,
                    Capacity = 10,
                    Status = true,
                    BranchId = 2,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Table
                {
                    Id = 7,
                    Capacity = 10,
                    Status = true,
                    BranchId = 2,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Table
                {
                    Id = 8,
                    Capacity = 10,
                    Status = true,
                    BranchId = 2,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Table
                {
                    Id = 9,
                    Capacity = 10,
                    Status = true,
                    BranchId = 2,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Table
                {
                    Id = 10,
                    Capacity = 10,
                    Status = true,
                    BranchId = 2,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }

                );

        }
    }
}
