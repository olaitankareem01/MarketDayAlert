using MarketDayAlertApp.Context;
using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private ApplicationDbContext _dbContext;
        public LocationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(MarketLocation location)
        {
            _dbContext.MarketLocations.Add(location);
            _dbContext.SaveChanges();

        }

        public MarketLocation Find(int Id)
        {
            return _dbContext.MarketLocations.Find(Id);

        }

        public IList<LocationDto> ListLocation()
        {
            return _dbContext.MarketLocations.Select(l => new LocationDto {
                Id = l.Id,
                Name = l.Name,
                State = l.State

            }).ToList();

        }

        public void Update(MarketLocation location)
        {
            _dbContext.MarketLocations.Update(location);
            _dbContext.SaveChanges(); 
        }

        public void Delete(MarketLocation location)
        {
            _dbContext.MarketLocations.Remove(location);
            _dbContext.SaveChanges();
        }
    }
}
