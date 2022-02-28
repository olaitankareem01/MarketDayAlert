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

        public void CreateMarket(CreateMarketDto market)
        {
            var location = _locationRepository.Find(market.LocationId);
            if(location != null)
            {
                var NewMarket = new Market
                {
                    Name = market.Name,
                    Address = market.Address,
                    LocationId = market.LocationId,
                    StartDate = market.StartDate,
                    Frequency = market.Frequency
                };
                _marketRepository.Create(NewMarket);
            }
            else
            {
                throw new Exception("the location selected is invalid ");
            }
            
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

        public MarketDto FindMarket(int Id)
        {
            var MarketFound =  _marketRepository.Find(Id);
            if(MarketFound != null)
            {
                var marketDto = new MarketDto
                {
                    Id = MarketFound.Id,
                    Name = MarketFound.Name,
                /*    LocationId = MarketFound.LocationId,*/
                    Frequency = MarketFound.Frequency,
                    Address = MarketFound.Address,
                    StartDate = MarketFound.StartDate,
                    NextMarket = MarketFound.StartDate.AddDays((double)MarketFound.Frequency)
                };
                return marketDto;
            }
            return null;
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
