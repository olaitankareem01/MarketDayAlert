using MarketDayAlertApp.Entities;
using MarketDayAlertApp.Models.DTOs;
using MarketDayAlertApp.Models.Enums;
using MarketDayAlertApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly IMarketService _marketService;
        private readonly IUserService _userService;
        private readonly ISubscriptionRepository _subRepository;
        private readonly INotificationRepository _notificationRepository;
        public SubscriptionService(
                     IMarketService marketService,
                    IUserService userService,
                    ISubscriptionRepository subRepository,
                    INotificationRepository notificationRepository)
        {
            _marketService = marketService;
            _userService = userService;
            _subRepository = subRepository;
            _notificationRepository = notificationRepository;
        }
        public bool Subscribe(CreateSubscriptionDto sub)
        {
            var user = _userService.FindUser(sub.UserId);
            var market = _marketService.FindMarket(sub.MarketId);
            if(user!=null && market != null)
            {
                var NewSub = new UserSubscription
                {
                    UserId = sub.UserId,
                    MarketId = sub.MarketId
                };

                _subRepository.Create(NewSub);

                var NewNote = new Notification
                {
                    RecipientEmail = user.Email,
                    Message = $"{sub.MarketName} would hold on {market.NextMarket}",
                    ScheduledDate = market.NextMarket,
                    Type = SubscriptionType.EveryTime
                };

                _notificationRepository.Create(NewNote);

                return true;
            }
            return false;
    
        }
    }
}
