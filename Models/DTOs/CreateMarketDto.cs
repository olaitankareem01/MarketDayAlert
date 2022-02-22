using MarketDayAlertApp.Entities;
using System;
using System.Collections.Generic;

namespace MarketDayAlertApp.Models.DTOs
{
    public class CreateMarketDto
    {
      
        public string Name { get; set; }

        public string Address { get; set; }

        public int Frequency { get; set; }

        public DateTime StartDate { get; set; }

        public int LocationId { get; set; }


    }
}