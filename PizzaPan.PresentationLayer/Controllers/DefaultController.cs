using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}