using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AdminProductController : Controller
    {
        private readonly IProductService _productService;

        public AdminProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            //var values = _productService.TGetList();

            var values = _productService.TGetProductsWithCategoryList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.TInsert(product);

            return RedirectToAction("Index");
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

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);

            return RedirectToAction("Index");
        }
    }
}