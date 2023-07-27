using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PizzaPan.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class MenuController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}