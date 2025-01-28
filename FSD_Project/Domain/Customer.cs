using FSD_Project.Data;

namespace FSD_Project.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }

        // Foreign Key to FSD_ProjectUser
        public string? UserId { get; set; }

        // Navigation property
        public FSD_ProjectUser? User { get; set; }

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
