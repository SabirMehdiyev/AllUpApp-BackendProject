namespace AllUpApp_BackendProject.Models
{
    public class Brand:BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
