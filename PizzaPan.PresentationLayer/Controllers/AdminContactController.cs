using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IContactService _contactService;

        public AdminContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetList();

            return View(values);
        }


        [HttpGet]
        public IActionResult DeleteMessage(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);

            return RedirectToAction("Index");
        }

        public IActionResult GetMessageByThx()
        {
            var values = _contactService.TGetContactSubjectWithThx();

            return View(values);
        }
    }
}