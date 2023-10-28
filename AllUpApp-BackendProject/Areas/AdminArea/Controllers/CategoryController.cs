using AllUpApp_BackendProject.DAL;
using AllUpApp_BackendProject.Models;
using AllUpApp_BackendProject.ViewModels.Admin.CategoryVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AllUpApp_BackendProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        private readonly IWebHostEnvironment _webHostEnvironment;

        public CategoryController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories.Where(c=>c.IsMain&&!c.IsDeleted).ToList(),"Id","Name");
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(CreateCategoryVM category)
        {
            if (!ModelState.IsValid) return View(category);

            var IsExistCategoryWithName = _context.Categories.Any(c => c.Name.ToLower() == category.Name.ToLower());
            if (IsExistCategoryWithName)
            {
                ModelState.AddModelError("Name", "eyni adli ola bilmez");
                return View(category);
            }


            Category newCategory = new Category
            {
                Name = category.Name,
                ImageUrl = category.Photo != null ? category.Photo.FileName : null,
                ParentId = category.ParentId,
                IsMain = category.IsMain
            };
            if (category.IsMain)
            {
                newCategory.ParentId = null;
            }
            else
            {
                newCategory.ParentId = category.ParentId;
            }
            if (category.Photo != null)
            {
                string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images"); 
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + category.Photo.FileName;
                string filePath = Path.Combine(uploadPath, uniqueFileName);
                category.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                newCategory.ImageUrl = uniqueFileName;
            }


            _context.Categories.Add(newCategory);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Remove(int? id)
        {
            if (id == null) return NotFound();
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();

            string path = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images", category.ImageUrl);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            var existCategory = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (existCategory == null) return NotFound();
            UpdateCategoryVM updateCategoryVM = new()
            {
                Name = existCategory.Name
            };
            return View(updateCategoryVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(UpdateCategoryVM updateCategoryVM, int id)
        {
            if (!ModelState.IsValid) return NotFound();
            var existCategory = _context.Categories.FirstOrDefault(c => c.Id == id);
            var IsExistCategoryWithName = _context.Categories.Any(c => c.Name.ToLower() == updateCategoryVM.Name.ToLower() && c.Id != id);
            if (IsExistCategoryWithName)
            {
                ModelState.AddModelError("Name", "eyni adli ola bilmez");
                return View();
            }
            existCategory.Name = updateCategoryVM.Name;
            if (updateCategoryVM.Photo != null)
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images", existCategory.ImageUrl);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }

                string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + updateCategoryVM.Photo.FileName;
                string filePath = Path.Combine(uploadPath, uniqueFileName);
                updateCategoryVM.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                existCategory.ImageUrl = uniqueFileName;
            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
