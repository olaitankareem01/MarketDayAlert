using MarketDayAlertApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Repositories
{
    public interface IItemRepository
    {
        public void Create(Item CreateItemModel);

        public void Update(Item item);

        public IList<Item> ListItem();

        public Item Find(int Id);

        public void Delete(Item item);
    }
}
