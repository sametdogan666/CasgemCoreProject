using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.Controllers
{
    [Authorize]
    public class AdminFeatureController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}