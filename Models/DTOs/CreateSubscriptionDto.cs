using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Models.DTOs
{
    public class CreateSubscriptionDto
    {
        public int MarketId { get; set; }

        public string MarketName { get; set; }

        public string MarketAddress { get; set; }

        public int UserId { get; set; }

        public int NotificationType { get; set; }


    }
}
