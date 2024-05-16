namespace LuxGamingShop.Models
{
    public class Trendgame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Path { get; set; }

        public int Price { get; set; }
        public int DiscountPrice { get; set; }
    }
}
