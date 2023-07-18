using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _FeaturePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.title1 = "Her gün pizza yiyin";
            ViewBag.title2 = "Sevdiğiniz pizzaları paylaşın";

            return View();
        }
    }
}