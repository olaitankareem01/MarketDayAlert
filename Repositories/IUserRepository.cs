using MarketDayAlertApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Repositories
{
    public interface IUserRepository
    {

        public void Create(User CreateUserModel);

        public void Update(User market);

        public IList<User> ListUser();

        public User Find(int Id);
        public void Delete(User user);

    }
}
