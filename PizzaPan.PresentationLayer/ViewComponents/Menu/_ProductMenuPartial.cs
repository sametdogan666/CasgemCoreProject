using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Concrete;
using PizzaPan.PresentationLayer.ViewModels;

namespace PizzaPan.PresentationLayer.ViewComponents.Menu
{
    public class _ProductMenuPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly Context _context;
        public _ProductMenuPartial(ICategoryService categoryService, IProductService productService, Context context)
        {
            _categoryService = categoryService;
            _productService = productService;
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            //BadCodess
            //var viewModel = new CategoryProductViewModel
            //{
            //    Categories = _categoryService.TGetList(),
            //    ProductsPerCategory = _productService.ProductsPerCategory()
            //};

            var response = _context.Categories.Include(x => x.Products.Take(4)).ToList();
            return View(response);
        }
    }
}