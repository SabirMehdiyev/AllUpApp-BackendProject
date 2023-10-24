namespace AllUpApp_BackendProject.Models
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public int? ParentId { get; set; }
        public Category Parent { get; set; }
        public bool IsMain { get; set; }
    }
}
