using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly ICompanyInfoService _companyInfoService;
        private readonly IContactService _contactService;

        public ContactController(ICompanyInfoService companyInfoService, IContactService contactService)
        {
            _companyInfoService = companyInfoService;
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CompanyInfo companyInfos = new CompanyInfo();
            companyInfos = _companyInfoService.TGetList().FirstOrDefault();
            ViewBag.CompanyInfo = companyInfos;

            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.ContactSendDateMessage = DateTime.Now;
            _contactService.TInsert(contact);

            return RedirectToAction("Index", "Default");
        }
    }
}