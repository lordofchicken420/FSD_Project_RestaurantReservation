namespace FSD_Project.Domain
{
    public class Branch : BaseDomainModel
    {
        public String? Name { get; set; }
        public String? Location { get; set; }
        public int contactNumber { get; set; }
        public int NumOfTables { get; set;  }
        public virtual ICollection<Staff> Staffs { get; set; } = new List<Staff>();
        public virtual ICollection<Table> Tables { get; set; } = new List<Table>();
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();


    }
}
