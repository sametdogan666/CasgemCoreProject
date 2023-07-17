using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;
using PizzaPan.PresentationLayer.Models;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AdminProductImageController : Controller
    {
        private readonly IProductImageService _productImageService;

        public AdminProductImageController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ImageFileViewModel model)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(model.ImageFile.FileName);
            var imageName = Guid.NewGuid() + extension;
            var saveLocation = resource + "/wwwroot/images/" + imageName;
            var stream = new FileStream(saveLocation, FileMode.Create);
            model.ImageFile.CopyTo(stream);
            ProductImage productImage = new ProductImage();
            productImage.ImageUrl = imageName;

            _productImageService.TInsert(productImage);

            return RedirectToAction("ImageList");
        }
    }
}