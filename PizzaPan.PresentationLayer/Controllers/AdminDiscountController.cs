using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;
using System.Text;
using System;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AdminDiscountController : Controller
    {
        private readonly IDiscountService _discountService;

        public AdminDiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public IActionResult Index()
        {
            var values = _discountService.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCode()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCode(Discount discount)
        {
            discount.EndDate = discount.CreatedDate.AddDays(3);

            _discountService.TInsert(discount);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeleteCode(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCode(int id)
        {
            var value = _discountService.TGetById(id);
            ViewBag.code = value.DiscountCode;
            ViewBag.createdDate = value.CreatedDate.ToShortDateString();
            ViewBag.endDate = value.EndDate.ToShortDateString();

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCode(Discount discount)
        {

            _discountService.TUpdate(discount);

            return RedirectToAction("Index");
        }
    }
}