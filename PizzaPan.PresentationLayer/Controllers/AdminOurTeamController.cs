using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.BusinessLayer.ValidationRules.OurTeamValidator;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AdminOurTeamController : Controller
    {
        private readonly IOurTeamService _teamService;

        public AdminOurTeamController(IOurTeamService teamService)
        {
            _teamService = teamService;
        }


        public IActionResult Index()
        {
            var values = _teamService.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddOurTeam()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOurTeam(OurTeam ourTeam)
        {
            OurTeamValidator ourTeamValidator = new OurTeamValidator();
            ValidationResult result = ourTeamValidator.Validate(ourTeam);
            if (result.IsValid)
            {
                _teamService.TInsert(ourTeam);
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
        public IActionResult DeleteOurTeam(int id)
        {
            var value = _teamService.TGetById(id);
            _teamService.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateOurTeam(int id)
        {
            var value = _teamService.TGetById(id);

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateOurTeam(OurTeam ourTeam)
        {
            OurTeamValidator ourTeamValidator = new OurTeamValidator();
            ValidationResult result = ourTeamValidator.Validate(ourTeam);
            if (result.IsValid)
            {
                _teamService.TUpdate(ourTeam);
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