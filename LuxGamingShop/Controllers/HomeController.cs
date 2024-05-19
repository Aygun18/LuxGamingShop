using LuxGamingShop.DAL;
using LuxGamingShop.Models;
using LuxGamingShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LuxGamingShop.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _db;
        public HomeController(AppDbContext db)
        {
             _db=db;
        }
        public IActionResult Index()
        {
            var features = _db.Features.ToList();

            var gaming = _db.Gamings.ToList();
            

            Header header = new Header
            {
                Id = 1,
                Title = "Welcome to lugx!",
                Description = "BEST GAMING SITE EVER",
                Text = "LUGX Gaming is free Bootstrap 5 HTML CSS website template for your gaming websites. You can download and use this layout for commercial purposes. Please tell your friends about TemplateMo.",
                Path = "banner-image.jpg",
                Price = 50,
                Discount = 30
            };

            var trendgames=_db.Trendgames.ToList();

            HomeIndexVM homeIndexVM = new HomeIndexVM();
            homeIndexVM.Features = features;
            homeIndexVM.Gamings = gaming;
            homeIndexVM.Header = header;
            homeIndexVM.Trendgames = trendgames;

            return View(homeIndexVM);


        }



    }


}
