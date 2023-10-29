using AllUpApp_BackendProject.DAL;
using AllUpApp_BackendProject.Models;
using AllUpApp_BackendProject.ViewModels.Admin.SliderVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllUpApp_BackendProject.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderController:Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public SliderController(AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_appDbContext.Sliders.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(CreateSliderVM sliderVM)
        {
            if (ModelState.IsValid)
            {
                var newSlider = new Slider
                {
                    MainTitle = sliderVM.MainTitle,
                    SubTitle = sliderVM.SubTitle,
                    Description = sliderVM.Description,
                    Link = sliderVM.Link,
                    ImageUrl = sliderVM.Photo.FileName
                };

                if (sliderVM.Photo != null)
                {
                    string uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + sliderVM.Photo.FileName;
                    string filePath = Path.Combine(uploadPath, uniqueFileName);
                    sliderVM.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    newSlider.ImageUrl = uniqueFileName;
                }

                _appDbContext.Sliders.Add(newSlider);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sliderVM);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var existSlider = _appDbContext.Sliders.FirstOrDefault(s => s.Id == id);
            if (existSlider == null) return NotFound();

            string path = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images", existSlider.ImageUrl);
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            _appDbContext.Sliders.Remove(existSlider);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            var existSlider = _appDbContext.Sliders.FirstOrDefault(s => s.Id == id);
            if (existSlider == null) return NotFound();
            return View(new UpdateSliderVM { ImageUrl = existSlider.ImageUrl });
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(UpdateSliderVM updateSliderVM)
        {
            if (ModelState.IsValid)
            {
                var existingSlider = _appDbContext.Sliders.FirstOrDefault(s => s.Id == updateSliderVM.Id);

                if (existingSlider == null)
                {
                    return NotFound();
                }

                if (!string.IsNullOrEmpty(updateSliderVM.MainTitle))
                {
                    existingSlider.MainTitle = updateSliderVM.MainTitle;
                }

                if (!string.IsNullOrEmpty(updateSliderVM.SubTitle))
                {
                    existingSlider.SubTitle = updateSliderVM.SubTitle;
                }

                if (!string.IsNullOrEmpty(updateSliderVM.Description))
                {
                    existingSlider.Description = updateSliderVM.Description;
                }

                if (!string.IsNullOrEmpty(updateSliderVM.Link))
                {
                    existingSlider.Link = updateSliderVM.Link;
                }

                if (updateSliderVM.Photo != null)
                {
                    string path = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images", existingSlider.ImageUrl);

                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }

                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + updateSliderVM.Photo.FileName;
                    string newImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "assets/images", uniqueFileName);
                    using (var stream = new FileStream(newImagePath, FileMode.Create))
                    {
                        updateSliderVM.Photo.CopyTo(stream);
                    }

                    existingSlider.ImageUrl = uniqueFileName;
                }

                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(updateSliderVM);
        }

        public IActionResult Details(int id)
        {
            var slider = _appDbContext.Sliders.FirstOrDefault(s => s.Id == id);

            if (slider == null)
            {
                return NotFound(); 
            }

            return View(slider);
        }

    }
}
