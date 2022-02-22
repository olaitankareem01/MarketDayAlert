using MarketDayAlertApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Entities
{
    public class Notification
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public NotificationType Type { get; set; }
        public string RecipientEmail { get; set; }
        public DateTime ScheduledDate { get; set; }
    }
}
