using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models;
using MarketDayAlertApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        public void CreateLocation(MarketLocation location)
        {
            _locationRepository.Create(location);
        }

        public void DeleteLocation(int Id)
        {
            var location = _locationRepository.Find(Id);

            if(location == null)
            {
                throw new Exception("Market Location not found");
            }
            _locationRepository.Delete(location);
        }

        public MarketLocation FindLocation(int Id)
        {
            return _locationRepository.Find(Id);
        }

        public IList<MarketLocation> ListLocations()
        {
            return _locationRepository.ListLocation();
        }

        public void UpdateLocation(UpdateLocationDto UpdatedLocation,int Id)
        {
            var location = _locationRepository.Find(Id);

            if(location == null)
            {
                throw new Exception("Market Location not found");
            }
            location.Name = UpdatedLocation.Name;
            location.State = UpdatedLocation.State;
            _locationRepository.Update(location);
        }
    }
}
