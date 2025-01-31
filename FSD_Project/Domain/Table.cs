namespace FSD_Project.Domain;

public class Table : BaseDomainModel
{
    public int Capacity { get; set; }  // Ensure this line exists
    public Boolean Status { get; set; } = true;
    public int BranchId { get; set; }
    public Branch? Branch { get; set; }
    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
