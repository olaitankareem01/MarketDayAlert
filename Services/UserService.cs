using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models.DTOs;
using MarketDayAlertApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void CreateUser(UserDto user)
        {
            _userRepository.Create(user);
        }

        public void DeleteUser(int Id)
        {
            var user = _userRepository.Find(Id);

            if(user == null)
            {
                throw new Exception($"user with Id {Id} not found");
            }
            _userRepository.Delete(user);
        }

        public UserDto FindUser(int Id)
        {
            var  UserFound =  _userRepository.Find(Id);
            if(UserFound != null)
            {
                var user = new UserDto
                {
                    Email = UserFound.Email,
                    FirstName = UserFound.FirstName,
                    LastName = UserFound.LastName,
                    Address = UserFound.Address,
                    DOB = UserFound.DOB,
                    LocationId = UserFound.LocationId,
                 
                };
                return user;
            }
            else
            {
                throw new Exception("user not found");
            }
        }

        public IList<UserDto> ListUsers()
        {
            return _userRepository.ListUser();
        }

        public void UpdateUser(UpdateUserDto UpdatedUser, int Id)
        {
            var user = _userRepository.Find(Id);

            if(user == null)
            {
                throw new Exception($"user with Id {Id} not found");
            }
            user.FirstName = UpdatedUser.FirstName;
            user.DOB = UpdatedUser.DOB;
            user.LocationId = UpdatedUser.UserType;
            _userRepository.Update(user);
        } 
    }
}
