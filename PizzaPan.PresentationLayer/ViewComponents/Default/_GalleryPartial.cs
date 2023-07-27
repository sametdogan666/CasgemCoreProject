using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _GalleryPartial:ViewComponent
    {
        private readonly IProductImageService _imageService;

        public _GalleryPartial(IProductImageService imageService)
        {
            _imageService = imageService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _imageService.TGetList();
                        
            return View(result);
        }
    }
}