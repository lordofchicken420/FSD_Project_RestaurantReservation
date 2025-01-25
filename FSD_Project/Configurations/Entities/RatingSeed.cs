using Microsoft.EntityFrameworkCore;
using FSD_Project.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSD_Project.Configurations.Entities
{
    public class RatingSeed : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasData(
                new Rating
                {
                    Id = 1,
                    Score = 5,
                    Comments = "The Souvlaki's flavour was unlike anything I've ever had before!",
                    ReservationId = 1, // Matches Reservation.Id
                    CustomerId = "1",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Rating
            {
                Id = 2,
                Score = 5,
                Comments = "The Baklava was the perfect way to end off this fantastic meal!",
                ReservationId = 2, // Matches Reservation.Id
                CustomerId = "2",
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
                CreatedBy = "System",
                UpdatedBy = "System"
            }







                );

        }
    }
}
