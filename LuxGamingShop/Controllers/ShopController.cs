using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
