using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.BusinessLayer.ValidationRules.AboutValidator;
using PizzaPan.BusinessLayer.ValidationRules.BlockValidator;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.Controllers
{
    [Authorize]
    public class AdminBlockController : Controller
    {
        private readonly IBlockService _blockService;

        public AdminBlockController(IBlockService blockService)
        {
            _blockService = blockService;
        }

        public IActionResult Index()
        {
            ViewBag.countBlock = _blockService.TGetList().Count;

            var values = _blockService.TGetList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddBlock()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBlock(Block block)
        {
            BlockValidator blockValidator = new BlockValidator();
            ValidationResult result = blockValidator.Validate(block);

            if (result.IsValid)
            {
                _blockService.TInsert(block);
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
        public IActionResult DeleteBlock(int id)
        {
            var value = _blockService.TGetById(id);
            _blockService.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateBlock(int id)
        {
            var value = _blockService.TGetById(id);

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateBlock(Block block)
        {
            BlockValidator blockValidator = new BlockValidator();
            ValidationResult result = blockValidator.Validate(block);

            if (result.IsValid)
            {
                _blockService.TUpdate(block);
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