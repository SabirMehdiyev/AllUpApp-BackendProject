namespace AllUpApp_BackendProject.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? AddedBy { get; set; }
        public bool IsDeleted { get; set; } 
    }
}
