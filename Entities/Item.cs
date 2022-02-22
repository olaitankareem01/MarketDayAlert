using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Entities
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Market> ItemMarkets { get; set; }
    }
}
