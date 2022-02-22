using MarketDayAlertApp.Context;
using MarketDayAlertApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Controllers
{
    public class MarketsController : Controller
    {
        private readonly IMarketService _marketService;
        public MarketsController(IMarketService marketService)
        {
            _marketService = marketService;
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
            return View();
        }

        // GET: MarketsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MarketsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
