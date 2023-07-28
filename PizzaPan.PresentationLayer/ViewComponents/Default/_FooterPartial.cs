using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;
using System.Linq;

namespace PizzaPan.PresentationLayer.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        private readonly ICompanyInfoService _companyInfoService;

        public _FooterPartial(ICompanyInfoService companyInfoService)
        {
            _companyInfoService = companyInfoService;
        }

        public IViewComponentResult Invoke()
        {
            CompanyInfo companyInfos = new CompanyInfo();
            companyInfos = _companyInfoService.TGetList().FirstOrDefault();
            ViewBag.CompanyInfo = companyInfos;

            return View();
        }
    }
}