using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Repositories
{
    public interface IUserRepository
    {

        public void Create(User user);

        public void Update(User market);

        public IList<UserDto> ListUser();

        public User FindByEmail(string Email);
        public User Find(int Id);
        public void Delete(User user);

    }
}
