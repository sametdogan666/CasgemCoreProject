using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        private readonly IProductService _productService;

        public _FeaturePartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.title1 = "Her gün pizza yiyin";
            ViewBag.title2 = "Sevdiğiniz pizzaları paylaşın";

            var value = _productService.GetCheapestPizza();

            return View(value);
        }
    }
}