using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Services
{
    public interface ILocationService
    {

        public void CreateLocation(MarketLocation location);

        public void UpdateLocation(UpdateLocationDto UpdatedLocation,int Id);

        public IList<MarketLocation> ListLocations();

        public void DeleteLocation(int Id);

        public MarketLocation FindLocation(int Id);

    }
}
