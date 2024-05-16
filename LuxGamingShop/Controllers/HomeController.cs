using LuxGamingShop.Models;
using LuxGamingShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var features = new List<Feature>();
            features.Add(new Feature { Id = 1, Title = "free storage1", Path = "featured-01.png" });
            features.Add(new Feature { Id = 2, Title = "user more2", Path = "featured-02.png" });
            features.Add(new Feature { Id = 3, Title = "reply ready3", Path = "featured-03.png" });
            features.Add(new Feature { Id = 4, Title = "easy layout4", Path = "featured-04.png" });


            var gaming = new List<Gaming>();
            gaming.Add(new Gaming { Id = 1, Tittle = "Warframe", Path = "top-game-01.jpg", CategoriesName = "Adventure" });
            gaming.Add(new Gaming { Id = 2, Tittle = "BatleGrounds", Path = "top-game-02.jpg", CategoriesName = "Pubg" });
            gaming.Add(new Gaming { Id = 3, Tittle = "Apex", Path = "top-game-03.jpg", CategoriesName = "Assasin1" });
            gaming.Add(new Gaming { Id = 4, Tittle = "Sims", Path = "top-game-04.jpg", CategoriesName = "Assasin2" });
            gaming.Add(new Gaming { Id = 5, Tittle = "Lostark", Path = "top-game-05.jpg", CategoriesName = "AssasinLostark" });

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

            List<Trendgame> trendgames = new List<Trendgame>
            {
                new Trendgame{Id=1,Name="Assasin Creed1",Category="Action1",Path="trending-01.jpg",Price=70,DiscountPrice=45},
                new Trendgame{Id=2,Name="Assasin Creed2",Category="Action2",Path="trending-02.jpg",Price=30,DiscountPrice=15},
                new Trendgame{Id=3,Name="Assasin Creed3",Category="Action3",Path="trending-03.jpg",Price=85,DiscountPrice=78},
                new Trendgame{Id=4,Name="Assasin Creed4",Category="Action4",Path="trending-04.jpg",Price=90,DiscountPrice=65}
            };
            HomeIndexVM homeIndexVM = new HomeIndexVM();
            homeIndexVM.Features = features;
            homeIndexVM.Gamings = gaming;
            homeIndexVM.Header= header;
            homeIndexVM.Trendgames = trendgames;

            return View(homeIndexVM);


        }



    }


}
