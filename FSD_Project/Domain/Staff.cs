using FSD_Project.Data;

namespace FSD_Project.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int BranchId { get; set; }
        public int ContactNumber { get; set; }

        public Branch? Branch { get; set; }

        // Foreign Key to FSD_ProjectUser
        public string? UserId { get; set; }

        // Navigation property
        public FSD_ProjectUser? User { get; set; }
    }
}
