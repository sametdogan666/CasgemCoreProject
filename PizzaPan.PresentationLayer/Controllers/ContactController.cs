using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}