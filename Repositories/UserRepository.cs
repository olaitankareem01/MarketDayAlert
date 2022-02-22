using MarketDayAlertApp.Context;
using MarketDayAlertApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public User Find(int Id)
        {
            return _dbContext.Users.Find(Id);
        }

        public IList<User> ListUser()
        {
            return _dbContext.Users.ToList();
        }

        public void Update(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
        }

        public void Delete(User user)
        {
             _dbContext.Users.Remove(user);
        }

    }
}
