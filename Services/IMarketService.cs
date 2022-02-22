using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Services
{
    public interface IMarketService
    {
        public void CreateMarket(Market market);

        public void UpdateMarket(UpdateMarketDto updatedMarket , int Id);

        public IList<MarketDto> ListMarkets();

        public void DeleteMarket(int Id);

        public Market FindMarket(int Id);


    }
}
