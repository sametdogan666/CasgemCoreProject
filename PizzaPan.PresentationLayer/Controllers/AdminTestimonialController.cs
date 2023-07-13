using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AdminTestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public AdminTestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IActionResult Index()
        {
            var values = _testimonialService.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            _testimonialService.TInsert(testimonial);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            _testimonialService.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);

            return RedirectToAction("Index");
        }
    }
}