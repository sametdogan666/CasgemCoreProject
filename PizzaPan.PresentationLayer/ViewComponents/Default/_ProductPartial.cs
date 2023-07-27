using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Math.EC.Rfc7748;
using PizzaPan.BusinessLayer.Abstract;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _ProductPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.GetAllPizza();

            return View(values);
        }
    }
}