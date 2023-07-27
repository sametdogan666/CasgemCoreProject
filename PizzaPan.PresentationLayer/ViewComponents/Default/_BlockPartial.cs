using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _BlockPartial : ViewComponent
    {
        private readonly IBlockService _blockService;

        public _BlockPartial(IBlockService blockService)
        {
            _blockService = blockService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _blockService.TGetList().FirstOrDefault();

            return View(value);
        }
    }
}