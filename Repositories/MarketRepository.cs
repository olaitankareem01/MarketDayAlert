using MarketDayAlertApp.Context;
using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models;
using MarketDayAlertApp.Models.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Repositories
{
    public class MarketRepository : IMarketRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public MarketRepository( ApplicationDbContext  dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Market market)
        {
            _dbContext.Markets.Add(market);
            _dbContext.SaveChanges();
        }

        public void Update(Market market)
        {
            _dbContext.Markets.Update(market);
            _dbContext.SaveChanges();
        }

        public IList<MarketDto> ListMarket()
        {
            return _dbContext.Markets.Select(m => new MarketDto
            {
                Id = m.Id,
                Name = m.Name,
                Address = m.Address,
                location = m.location.Name,
                Frequency = m.Frequency

            }).ToList();
        }

        public Market Find(int Id)
        {
            return _dbContext.Markets.Find(Id);
        }

        public void Delete(Market market)
        {
           _dbContext.Markets.Remove(market);
        }

    }
}
