using System.Linq;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.BusinessLayer.ValidationRules.CategoryValidator;
using PizzaPan.BusinessLayer.ValidationRules.ProductValidator;
using PizzaPan.DataAccessLayer.Concrete;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AdminProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly Context _context;

        public AdminProductController(IProductService productService, Context context)
        {
            _productService = productService;
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _productService.TGetProductsWithCategoryList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            var values = (from category in _context.Categories.ToList()
                select new SelectListItem
                {
                    Value = category.CategoryId.ToString(),
                    Text = category.CategoryName
                }).ToList();

            ViewBag.categoryName = values;

            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            ProductValidator productValidator = new ProductValidator();
            ValidationResult result = productValidator.Validate(product);

            if (result.IsValid)
            {
                _productService.TInsert(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }
        }


        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = _productService.TGetById(id);

            var values = (from category in _context.Categories.ToList()
                select new SelectListItem
                {
                    Value = category.CategoryId.ToString(),
                    Text = category.CategoryName
                }).ToList();

            ViewBag.categoryName = values;

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            ProductValidator productValidator = new ProductValidator();
            ValidationResult result = productValidator.Validate(product);

            if (result.IsValid)
            {
                _productService.TUpdate(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }
        }
    }
}