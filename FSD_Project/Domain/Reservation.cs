namespace FSD_Project.Domain
{
    public class Reservation : BaseDomainModel
    {
        public DateTime ReservedDateTime { get; set; }
        public int Pax { get; set; }

        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public int TableID { get; set;  }

    }
}
