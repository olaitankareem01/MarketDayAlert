using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models;
using MarketDayAlertApp.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Services
{
    public interface ILocationService
    {

        public void CreateLocation(CreateLocationDto location);

        public void UpdateLocation(UpdateLocationDto UpdatedLocation,int Id);

        public IList<LocationDto> ListLocations();

        public void DeleteLocation(int Id);

        public MarketLocation FindLocation(int Id);

    }
}
