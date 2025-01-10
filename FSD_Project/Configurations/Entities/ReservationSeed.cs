using Microsoft.EntityFrameworkCore;
using FSD_Project.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSD_Project.Configurations.Entities
{
    public class ReservationSeed : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasData(
                new Reservation
                {
                    Id = 1,
                    ReservedDateTime = DateTime.Now,
                    Pax = 3,
                    BranchId = 1,
                    CustomerId = 1,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Reservation
                {
                    Id = 2,
                    ReservedDateTime = DateTime.Now,
                    Pax = 2,
                    BranchId = 1,
                    CustomerId= 2,

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }







                );

        }
    }
}
