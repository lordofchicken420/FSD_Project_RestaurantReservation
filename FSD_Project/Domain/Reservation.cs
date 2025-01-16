namespace FSD_Project.Domain
{
    public class Reservation : BaseDomainModel
    {
        public DateTime ReservedDateTime { get; set; }
        public int Pax { get; set; }

        public int CustomerId { get; set; }
        public int TableID { get; set; }
        public Customer? Customer { get; set; }
        public Branch? Branch { get; set; } 
        public Table? Table { get; set; }  


    }
}
