using MarketDayAlertApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace MarketDayAlertApp.Context
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;port=3306;database=MarketAlert;uid=root;pwd=tsquare0601", new MySqlServerVersion(new Version()));
        }*/

        public DbSet<Market> Markets { get; set; }
        public DbSet<MarketLocation> MarketLocations { get; set; }

        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<MarketItem> MarketItems { get; set; }

        public DbSet<UserSubscription> UserSubscriptions { get; set; }

        public DbSet<Notification> Notifications { get; set; }

    }
}
