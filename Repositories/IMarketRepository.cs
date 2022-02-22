using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models;
using MarketDayAlertApp.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Repositories
{
    public interface IMarketRepository
    {
        public void Create(Market market);

        public void Update(Market market);  

        public IList<MarketDto> ListMarket();

        public Market Find(int Id);

        public void Delete(Market market);
    }
}
