using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Entities
{
    public class UserSubscription
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int MarketId { get; set; }

        public Market Market { get; set; }
    }
}
