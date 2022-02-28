﻿using MarketDayAlertApp.Context;
using MarketDayAlertApp.Models.DTOs;
using MarketDayAlertApp.Services;
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
        public MarketsController(IMarketService marketService,ILocationService locationService)
        {
            _marketService = marketService;
            _locationService = locationService;
        }
        // GET: MarketsController
        public ActionResult Index()
        {
            var markets = _marketService.ListMarkets();
            return View(markets);
        }

        // GET: MarketsController/Details/5
        public ActionResult Details(int id)
        {
            var market = _marketService.FindMarket(id);
            return View(market);
        }

        // GET: MarketsController/Create
        public ActionResult Create()
        {
            var locations = _locationService.ListLocations();
            List <SelectListItem> locationlists = new List<SelectListItem>();
            foreach(var item in locations)
            {
                locationlists.Add(new SelectListItem { Text = item.Name, Value = item.Id.ToString() });
            }
            ViewBag.locations = locationlists;
            return View();
        }

        // POST: MarketsController/Create
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MarketsController/Edit/5
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MarketsController/Delete/5
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
