using System.ComponentModel.DataAnnotations.Schema;

namespace AllUpApp_BackendProject.Models
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        [Column(TypeName = "money")]
        public double Price { get; set; }
        [Column(TypeName = "money")]
        public double DiscountPrice { get; set; }
        public bool IsAvailable { get; set; }
        public string MainImageUrl { get; set; }
        public double ExTax { get; set; }
        public string Code { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsFeatured { get; set; }
        public double IsBestSeller { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductTag> ProductTags { get; set; }

        public Product()
        { 
            ProductTags = new List<ProductTag>();
        }
    }
}
