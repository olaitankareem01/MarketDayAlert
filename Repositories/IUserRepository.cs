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

        public void Create(UserDto user);

        public void Update(User market);

        public IList<UserDto> ListUser();

        public User Find(int Id);
        public void Delete(User user);

    }
}
