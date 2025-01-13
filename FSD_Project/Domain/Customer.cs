namespace FSD_Project.Domain
{
    public class Customer : BaseDomainModel
    {
        public String? Name { get; set; }
        public String? Gender { get; set; }
        public int contactNumber { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    }
}
