using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("contact")]
        public IActionResult Contact()
        {

            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ViewModels.ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Send the email
                _mailService.SendMail("to.akos@gmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message} ")
            }

            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            ViewBag.Title = "About Us";

            return View();
        }
    }
}
