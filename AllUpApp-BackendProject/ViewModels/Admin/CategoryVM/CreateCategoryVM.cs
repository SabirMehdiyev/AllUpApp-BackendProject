using AllUpApp_BackendProject.Models;
using System.ComponentModel.DataAnnotations;

namespace AllUpApp_BackendProject.ViewModels.Admin.CategoryVM
{
    public class CreateCategoryVM
    {
        public string Name { get; set; }
        public IFormFile? Photo { get; set; }
        [Display(Name = "Parent Category")]
        public int? ParentId { get; set; }
        public bool IsMain { get; set; }
    }
}
