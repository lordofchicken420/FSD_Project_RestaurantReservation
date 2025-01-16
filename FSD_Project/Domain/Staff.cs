namespace FSD_Project.Domain
{
    public class Staff : BaseDomainModel
    {
        public String? Name { get; set; }
        public String? Gender { get; set; }
        public int BranchId { get; set; }
        public int contactNumber { get; set; }
        public Branch? Branch { get; set; }

    }
}
