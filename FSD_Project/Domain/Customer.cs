namespace FSD_Project.Domain
{
    public class Customer : BaseDomainModel
    {
        // Inherit Id from BaseDomainModel
        // public int CustomerId { get; set; } // Not needed if BaseDomainModel has 'Id'

        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
