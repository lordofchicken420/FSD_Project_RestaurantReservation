namespace FSD_Project.Domain
{
    public class Review : BaseDomainModel
    {
        public int Score { get; set; }
        public string? Comment { get; set; }
        public string? ReservationId { get; set; }
        public Reservation? Reservation { get; set; }

    }
}