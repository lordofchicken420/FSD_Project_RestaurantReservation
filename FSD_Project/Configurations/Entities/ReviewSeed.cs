using Microsoft.EntityFrameworkCore;
using FSD_Project.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSD_Project.Configurations.Entities
{
    public class ReviewSeed : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
                new Review
                {
                    Id = 1,
                    Score = 5,
                    Comment = "The Greek Salad was the perfect mix of vegetables, fruits and dressing!",
                    ReservationId = "1",

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Review
                {
                    Id = 2,
                    Score = 5,
                    Comment = "The Baklava was unlike anything I have ever eaten before",
                    ReservationId = "2",

                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }







                );

        }
    }
}