using System.Security.Cryptography.X509Certificates;
using LuxGamingShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            Contact contact = new Contact
            {
                Id = 1,
                Title = "CONTACT US",
                Desctiption = "Say Hello!",
                Text= "LUGX Gaming Template is based on the latest Bootstrap 5 CSS framework. This template is provided by TemplateMo and it is suitable for your gaming shop ecommerce websites. Feel free to use this for any purpose. Thank you.",
                Address= "Sunny Isles Beach, FL 33160, United States",
                Phone= "+123 456 7890",
                Email= "lugx@contact.com"
            };
            return View(contact);
        }
    }
}
