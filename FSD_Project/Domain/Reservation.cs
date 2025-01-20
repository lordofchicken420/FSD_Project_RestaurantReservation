namespace FSD_Project.Domain;

public class Reservation : BaseDomainModel
{
    public DateTime ReservedDateTime { get; set; }
    public int Pax { get; set; }
    public int? CustomerId { get; set; }
    public int TableID { get; set; } // Foreign key
    public Table? Table { get; set; } // Navigation property to Table
}
