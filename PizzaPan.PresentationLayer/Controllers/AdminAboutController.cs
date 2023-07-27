using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.BusinessLayer.ValidationRules.AboutValidator;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.Controllers
{
    [Authorize]
    public class AdminAboutController : Controller
    {
       private readonly IAboutService _aboutService;

       public AdminAboutController(IAboutService aboutService)
       {
           _aboutService = aboutService;
       }

       public IActionResult Index()
        {
            ViewBag.countAbout =  _aboutService.TGetList().Count;

            var values = _aboutService.TGetList();

            return View(values);
        }

       [HttpGet]
       public IActionResult AddAbout()
       {
           return View();
       }

       [HttpPost]
       public IActionResult AddAbout(About about)
       {
           AboutValidator aboutValidator = new AboutValidator();
           ValidationResult result = aboutValidator.Validate(about);

           if (result.IsValid)
           {
               _aboutService.TInsert(about);
               return RedirectToAction("Index");
           }
           else
           {
               foreach (var item in result.Errors)
               {
                   ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
               }

               return View();
           }

       }

       [HttpGet]
       public IActionResult DeleteAbout(int id)
       {
           var value = _aboutService.TGetById(id);
           _aboutService.TDelete(value);

           return RedirectToAction("Index");
       }

       [HttpGet]
       public IActionResult UpdateAbout(int id)
       {
           var value = _aboutService.TGetById(id);

           return View(value);
       }

       [HttpPost]
       public IActionResult UpdateAbout(About about)
       {
           AboutValidator aboutValidator = new AboutValidator();
           ValidationResult result = aboutValidator.Validate(about);

           if (result.IsValid)
           {
               _aboutService.TUpdate(about);
               return RedirectToAction("Index");
           }
           else
           {
               foreach (var item in result.Errors)
               {
                   ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
               }

               return View();
           }
       }
    }
}