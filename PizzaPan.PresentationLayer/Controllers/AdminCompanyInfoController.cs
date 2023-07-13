﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using PizzaPan.DataAccessLayer.Concrete;
using PizzaPan.EntityLayer.Concrete;

namespace PizzaPan.PresentationLayer.Controllers
{
    public class AdminCompanyInfoController : Controller
    {
        ICompanyInfoService _companyInfoService;
        private readonly Context _context;

        public AdminCompanyInfoController(ICompanyInfoService companyInfoService, Context context)
        {
            _companyInfoService = companyInfoService;
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _companyInfoService.TGetList();
            ViewBag.countCompany = _context.CompanyInfos.Count();

            return View(values);
        }


        [HttpGet]
        public IActionResult AddCompanyInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCompanyInfo(CompanyInfo companyInfo)
        {
            _companyInfoService.TInsert(companyInfo);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeleteCompanyInfo(int id)
        {
            var value = _companyInfoService.TGetById(id);
            _companyInfoService.TDelete(value);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCompanyInfo(int id)
        {
            var value = _companyInfoService.TGetById(id);

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCompanyInfo(CompanyInfo companyInfo)
        {
            _companyInfoService.TUpdate(companyInfo);

            return RedirectToAction("Index");
        }
    }
}