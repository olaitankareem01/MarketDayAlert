using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Repositories
{
    public interface ILocationRepository
    {
        public void Create(MarketLocation location);

        public void Update(MarketLocation market);

        public IList<LocationDto> ListLocation();

        public MarketLocation  Find(int Id);

        public void Delete(MarketLocation location);

    }
}
