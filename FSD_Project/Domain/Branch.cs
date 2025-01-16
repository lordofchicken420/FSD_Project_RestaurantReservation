namespace FSD_Project.Domain
{
    public class Branch : BaseDomainModel
    {
        public String? Name { get; set; }
        public String? Location { get; set; }
        public int contactNumber { get; set; }
        public int NumOfTables { get; set;  }
        public ICollection<Staff> Staffs { get; set; } = new List<Staff>();
        public ICollection<Table> Tables { get; set; } = new List<Table>();
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();


    }
}
