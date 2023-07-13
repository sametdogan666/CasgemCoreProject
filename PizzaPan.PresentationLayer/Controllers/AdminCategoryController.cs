using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AdminCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public AdminCategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = _categoryService.TGetById(id);

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);

            return RedirectToAction("Index");
        }
    }
}