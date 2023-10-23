namespace AllUpApp_BackendProject.Models
{
    public class Slider:BaseEntity
    {
        public string MainTitle { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string ImageUrl { get; set; }
    }
}
