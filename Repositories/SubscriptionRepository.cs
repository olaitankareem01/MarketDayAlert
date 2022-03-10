using MarketDayAlertApp.Context;
using MarketDayAlertApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SubscriptionRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(UserSubscription user)
        {
            _dbContext.UserSubscriptions.Add(user);
            _dbContext.SaveChanges();
        }
    }
}
