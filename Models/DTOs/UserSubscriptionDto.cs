using MarketDayAlertApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Models.DTOs
{
    public class UserSubscriptionDto
    {
        public int MarketId { get; set; }
        public Market market { get; set; }
        
        public int UserId { get; set; }

        public User user { get; set; }

       
    }
}
