using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Services
{
    public interface IUserService 
    {
        public void CreateUser(User user);

        public void UpdateUser(UpdateUserDto UpdatedUser, int Id);

        public IList<User> ListUsers();

        public void DeleteUser(int Id);

        public User FindUser(int Id);
    }
}
