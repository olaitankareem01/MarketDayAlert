using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models;
using MarketDayAlertApp.Models.DTOs;
using MarketDayAlertApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Services
{
    public class MarketService :IMarketService
    {
        private IMarketRepository _marketRepository;
        private ILocationRepository _locationRepository;
        public MarketService(IMarketRepository marketRepository, ILocationRepository locationRepository)
        {
            _marketRepository = marketRepository;
            _locationRepository = locationRepository;
        }

        public void CreateMarket(Market market)
        {
            var location = _locationRepository.Find(market.LocationId);
            if(location == null)
            {
                throw new Exception("the location selected is invalid ");
            }
            _marketRepository.Create(market);
        }

        public void DeleteMarket(int Id)
        {
            var market = _marketRepository.Find(Id);
             
            if(market == null)
            {
                throw new Exception("market not found");
            }
            _marketRepository.Delete(market);

        }

        public Market FindMarket(int Id)
        {
            return _marketRepository.Find(Id);
        }

        public IList<MarketDto> ListMarkets()
        {
            return _marketRepository.ListMarket();
        }

        public void UpdateMarket(UpdateMarketDto UpdatedMarket, int Id)
        {
            var market =  _marketRepository.Find(Id);

            if(market == null)
            {
                throw new Exception("market not found");
            }
            market.Name = UpdatedMarket.Name;
            market.LocationId = UpdatedMarket.LocationId;
            market.StartDate = UpdatedMarket.StartDate;
            _marketRepository.Update(market);
        }
    }
}
