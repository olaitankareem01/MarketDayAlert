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
        public void Create(UserDto user)
        {

            var newUser = new User
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                DOB = user.DOB,
                LocationId = user.LocationId
             
                
            };
            _dbContext.Users.Add(newUser);
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
