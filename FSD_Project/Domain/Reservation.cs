namespace FSD_Project.Domain;

public class Reservation : BaseDomainModel
{
    public DateTime ReservedDateTime { get; set; }
    public int Pax { get; set; }

    // In your Reservation model
    public string? CustomerId { get; set; }
    public int TableID { get; set; } // Foreign key
    public Table? Table { get; set; } // Navigation property to Table

    public ICollection<Review> Reviews { get; set; } = new List<Review>();

}