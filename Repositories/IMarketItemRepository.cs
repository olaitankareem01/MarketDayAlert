using MarketDayAlertApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Repositories
{
    public  interface IMarketItemRepository
    {

        public void Create(MarketItem CreateMarketItemModel);

        public void Update(MarketItem marketItem);

        public IList<MarketItem> ListMarketItem();

        public MarketItem Find(int Id);

        public void Delete(MarketItem item);
    }
}
