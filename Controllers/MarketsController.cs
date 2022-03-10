using MarketDayAlertApp.Context;
using MarketDayAlertApp.Models.DTOs;
using MarketDayAlertApp.Models.ViewModels;
using MarketDayAlertApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Controllers
{
    public class MarketsController : Controller
    {
        private readonly IMarketService _marketService;
        private readonly ILocationService _locationService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;
        private readonly ISubscriptionService _subscriptionService;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public MarketsController(
                         IMarketService marketService,
                          ILocationService locationService,
                          IHttpContextAccessor httpContextAccessor,
                          IUserService userService,
                          ISubscriptionService subscriptionService
                           )
        {
            _marketService = marketService;
            _locationService = locationService;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
            _subscriptionService = subscriptionService;
        }
        // GET: MarketsController
        [Authorize]
        public ActionResult Index()
        {
            var markets = _marketService.ListMarkets();
            return View(markets);
        }

        // GET: MarketsController/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            var market = _marketService.FindMarket(id);
            return View(market);
        }

        // GET: MarketsController/Create
        [Authorize]
        public ActionResult Create()
        {

                var locations = _locationService.ListLocations();
                ViewBag.locations = locations;
                return View();
       
         
        }

        // POST: MarketsController/Create
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateMarketDto market)
        {
            try
            {
                _marketService.CreateMarket(market);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MarketsController/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MarketsController/Edit/5
        [Authorize]
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

        // GET: MarketsController/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MarketsController/Delete/5
        [Authorize]
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

        [Authorize]
        public ActionResult Subscribe(int id)
        {
            var market = _marketService.FindMarket(id);
            int userId = (int)_session.GetInt32("UserId");
            ViewBag.UserId = userId;
            ViewBag.MarketName = market.Name;
            ViewBag.MarketId = market.Id;
            ViewBag.Frequency = market.Frequency;
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Subscribe(SubscriptionViewModel sub)
        {
            try
            {
                if(sub != null)
                {
                    var SubDto = new CreateSubscriptionDto
                    {
                        MarketName = sub.MarketName,
                        MarketId = sub.MarketId,
                        UserId = sub.UserId,
                        NotificationType = sub.NotificationType
                    };
                    var Subscribed = _subscriptionService.Subscribe(SubDto);
                    if (Subscribed != true)
                    {
                        ViewBag.error = "Subscription Unsuccessful!";
                    }
                    else
                    {
                        ViewBag.Message = "You have sucessfully subscribed for this market";
                    }
                }
               
             
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
