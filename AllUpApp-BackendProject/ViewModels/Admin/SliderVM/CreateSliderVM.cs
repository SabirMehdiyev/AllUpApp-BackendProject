using System.ComponentModel.DataAnnotations;

namespace AllUpApp_BackendProject.ViewModels.Admin.SliderVM
{
    public class CreateSliderVM
    {
        public string MainTitle { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}
