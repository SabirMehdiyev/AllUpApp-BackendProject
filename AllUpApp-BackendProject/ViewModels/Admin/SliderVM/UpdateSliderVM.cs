namespace AllUpApp_BackendProject.ViewModels.Admin.SliderVM
{
    public class UpdateSliderVM
    {
        public int Id { get; set; }
        public string? MainTitle { get; set; }
        public string? SubTitle { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }
        public IFormFile? Photo { get; set; }
        public string? ImageUrl { get; set; }
    }

}
