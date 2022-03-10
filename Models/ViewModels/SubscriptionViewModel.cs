using MarketDayAlertApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Models.ViewModels
{
    public class SubscriptionViewModel
    {
        [Required]
        public int MarketId { get; set; }

        [Required]
        public string MarketName { get; set; }
     
        
        [Required]
        public int UserId { get; set; }
        [Required]
        public int NotificationType { get; set; }
        [Required]
        public int Frequency { get; set; }


    }
}
