using MarketDayAlertApp.Context;
using MarketDayAlertApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private ApplicationDbContext _dbContext;
        public ItemRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Item item)
        {
            _dbContext.Items.Add(item);
            _dbContext.SaveChanges();
        }

        public Item Find(int Id)
        {
            return _dbContext.Items.Find(Id);
        }

        public IList<Item> ListItem()
        {
            return _dbContext.Items.ToList();
        }

        public void Update(Item item)
        {
            _dbContext.Items.Update(item);
            _dbContext.SaveChanges();
        }

        public void Delete(Item item)
        {
            _dbContext.Items.Remove(item);
        }

    }
}
