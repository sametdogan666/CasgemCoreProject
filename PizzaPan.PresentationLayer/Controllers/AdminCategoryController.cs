using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}