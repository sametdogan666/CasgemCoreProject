using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.PresentationLayer.ViewModels;

namespace PizzaPan.PresentationLayer.ViewComponents.Menu
{
    public class _ProductMenuPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public _ProductMenuPartial(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var viewModel = new CategoryProductViewModel
            {
                Categories = _categoryService.TGetList(),
                ProductsPerCategory = _productService.ProductsPerCategory()
            };

            return View(viewModel);
        }
    }
}