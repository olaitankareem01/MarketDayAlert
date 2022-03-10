using MarketDayAlertApp.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Services
{
    public interface ISubscriptionService
    {
        public bool Subscribe(CreateSubscriptionDto sub);
    }
}
