using Microsoft.EntityFrameworkCore;
using FSD_Project.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSD_Project.Configurations.Entities
{
    public class StaffSeed : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    Name = "Gordon Sim",
                    Gender = "Male",
                    contactNumber = 97581578,
                    BranchId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Staff
                {
                    Id = 2,
                    Name = "En Xuan",
                    Gender = "Female",
                    contactNumber = 98886482,
                    BranchId = 1,


                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }







                );

        }
    }
}
