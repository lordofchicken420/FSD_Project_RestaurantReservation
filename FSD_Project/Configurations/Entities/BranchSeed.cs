using Microsoft.EntityFrameworkCore;
using FSD_Project.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSD_Project.Configurations.Entities
{
    public class BranchSeed : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasData(
                new Branch
                {
                    Id = 1,
                    Name = "Branch 1",
                    Location = "Woodlands",
                    contactNumber = 61234567,
                    NumOfTables = 15,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Branch
                {
                    Id = 2,
                    Name = "Branch 2",
                    Location = "Punggol",
                    contactNumber = 61234566, 
                    NumOfTables = 15, 

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }







                );

        }
    }
}
