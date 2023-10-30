using System.ComponentModel.DataAnnotations.Schema;

namespace AllUpApp_BackendProject.Models
{
    public class Product : BaseEntity
    {
        public string MainImageUrl { get; set; }
        public string? HoverImageUrl { get; set; }
        public string ProductName { get; set; }
        public string MainDescription { get; set; }
        public string SubDescription { get; set; }
        public string Color { get; set; }
        [Column(TypeName = "money")]
        public double Price { get; set; }
        [Column(TypeName = "money")]
        public string DiscountPrice { get; set; }
        [Column(TypeName = "money")]
        public string ExTax { get; set; }
        public string ProductCode { get; set; }
        public bool IsAvailable { get; set; }
        public int StockCount { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime? CountDown { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; } 

    }
}
