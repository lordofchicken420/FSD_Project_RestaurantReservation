namespace FSD_Project.Domain
{
    public class Branch : BaseDomainModel
    {
        public String? Name { get; set; }
        public String? Location { get; set; }
        public int contactNumber { get; set; }
        public int NumOfTables { get; set;  }
    }
}
