using System.Text.Json.Serialization;

namespace FSD_Project.Domain
{
    public class Rating : BaseDomainModel
    {
        public required int Score { get; set; } // Rating score (e.g., 1-5)
        public required string Comments { get; set; } // Comments

        // FOREIGN KEYS
        public int? ReservationId { get; set; } // Keep for serialization if needed
        public string? CustomerId { get; set; } // Keep for serialization if needed

        // Navigation properties
        [JsonIgnore] // Ignore this during serialization
        public Reservation? Reservation { get; set; }

        [JsonIgnore] // Ignore this during serialization
        public Customer? Customer { get; set; }
    }

}
