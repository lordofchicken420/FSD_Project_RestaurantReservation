namespace FSD_Project.Domain
{
    public class Reservation : BaseDomainModel
    {
        public DateTime ReservedDateTime { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
    }
}
