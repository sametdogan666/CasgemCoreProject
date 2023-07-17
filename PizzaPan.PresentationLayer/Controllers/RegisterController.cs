using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PizzaPan.EntityLayer.Concrete;
using PizzaPan.PresentationLayer.Models;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using MimeKit;

namespace PizzaPan.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            Random rnd = new Random();
            int x = rnd.Next(100000, 1000000);

            AppUser appUser = new AppUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName,
                ConfirmCode = x
            };

            var result = await _userManager.CreateAsync(appUser, model.Password);


            if (result.Succeeded)
            {

                MimeMessage mimeMessage = new MimeMessage();
                MailboxAddress mailboxAddressFrom = new MailboxAddress("CasgemPizzaPan", "s.doqann1570@gmail.com");
                mimeMessage.From.Add(mailboxAddressFrom);

                MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.Email);
                mimeMessage.To.Add(mailboxAddressTo);

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = "Giriş yapabilmek için onaylama kodunuz: " + x;
                mimeMessage.Body = bodyBuilder.ToMessageBody();

                mimeMessage.Subject = "Doğrulama Kodu";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Connect("smtp.gmail.com", 587, false);
                smtpClient.Authenticate("s.doqann1570@gmail.com", "");
                smtpClient.Send(mimeMessage);
                smtpClient.Disconnect(true);

                TempData["Mail"] = model.Email;

                return RedirectToAction("ConfirmMail", "Register");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            return View();

        }


        [HttpGet]
        public IActionResult ConfirmMail()
        {
            var value = TempData["Mail"];

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmMail(ConfirmMailViewModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Mail);

            if (user.ConfirmCode == model.ConfirmCode)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);

                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}