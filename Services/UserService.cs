using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models.DTOs;
using MarketDayAlertApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCrypt.Net;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace MarketDayAlertApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public UserService(IUserRepository userRepository, IHttpContextAccessor httpContextAccessor)
        {
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
           
        }

        public bool Login(string Email, string Password)
        {
            var User = _userRepository.FindByEmail(Email);

            var IsValidPassword = BCrypt.Net.BCrypt.Verify(Password, User.Password);

            if (User != null && IsValidPassword == true)
            {
              return true;
                 
            }

            return false;
        }
        public void CreateUser(UserDto user)
        {
            if (user != null)
            {
                var UserExists = _userRepository.FindByEmail(user.Email);
                if (UserExists != null)
                {
                    throw new Exception($"user with email {user.Email} already exists");
                }

                var HashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);

                var NewUser = new User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    DOB = user.DOB,
                    Address = user.Address,
                    LocationId = user.LocationId,
                    Password = HashedPassword
                };
                _userRepository.Create(NewUser);
            }

          
        }

        public void DeleteUser(int Id)
        {
            var user = _userRepository.Find(Id);

            if (user == null)
            {
                throw new Exception($"user with Id {Id} not found");
            }
            _userRepository.Delete(user);
        }

        public UserDto FindUser(int Id)
        {
            var UserFound = _userRepository.Find(Id);
            if (UserFound != null)
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

            if (user == null)
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
