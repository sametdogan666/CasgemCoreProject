using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _BlockPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}