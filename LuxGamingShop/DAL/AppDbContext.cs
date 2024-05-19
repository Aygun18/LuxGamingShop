using LuxGamingShop.Models;
using Microsoft.EntityFrameworkCore;

namespace LuxGamingShop.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext) { }

       public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Gaming> Gamings { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Trendgame> Trendgames { get; set; }
    }
}
