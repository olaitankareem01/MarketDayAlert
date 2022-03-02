using MarketDayAlertApp.Models.DTOs;
using MarketDayAlertApp.Models.ViewModels;
using MarketDayAlertApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
       

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: AccountController
        public ActionResult Index()
        {
            var users = _userService.ListUsers();
            return View(users);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel user)
        {
            try
            {
                var IsAccountValid = _userService.Login(user.Email, user.Password);
                if(IsAccountValid == false)
                {
                    ViewBag.Message = "Email or Password is Invalid!";
                    return View();
                }
                ViewBag.Message = "Login Successful!";
             
                return RedirectToAction("Index","Home");
            }
            catch
            {
                return View();
            }
          
        }
        // GET: AccountController/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(CreateUserViewModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var NewUser = new UserDto
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        Address = user.Address,
                        DOB = user.DOB,
                        LocationId = user.LocationId,
                        Password = user.Password
                    };

                    _userService.CreateUser(NewUser);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
