using MarketDayAlertApp.Context;
using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models.DTOs;
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

        public IList<UserDto> ListUser()
        {
            return _dbContext.Users.Select(u => new UserDto { 
              Id = u.Id,
              Email = u.Email,
              FirstName = u.FirstName,
              LastName = u.LastName,
              Address = u.Address,
              LocationId = u.LocationId,
              DOB = u.DOB,
              
            }).ToList();
        }

        public User FindByEmail(string Email)
        {
            return _dbContext.Users.SingleOrDefault(u => u.Email == Email);
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
