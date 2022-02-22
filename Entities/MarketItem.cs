using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Entities
{
    public class MarketItem
    {
        public int Id { get; set; }

        public int MarketId { get; set; }
        public Market market { get; set; }
        public int ItemId { get; set; }
        public Item item { get; set; }


    }
}
