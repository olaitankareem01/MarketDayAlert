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
        public void CreateUser(UserDto user);

        public void UpdateUser(UpdateUserDto UpdatedUser, int Id);

        public IList<UserDto> ListUsers();

        public void DeleteUser(int Id);

        public UserDto FindUser(int Id);


        public bool Login(string Email, string Password);
    }
}
