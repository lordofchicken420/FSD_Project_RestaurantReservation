namespace FSD_Project.Domain
{
    public class Table : BaseDomainModel
    {
        public int Capacity { get; set; }
        public Boolean Status { get; set; }
        public int BranchId { get; set; } 
    }
}
