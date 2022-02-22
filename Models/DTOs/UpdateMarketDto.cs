using MarketDayAlertApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Models.DTOs
{
    public class UpdateMarketDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public int Frequency { get; set; }

        public DateTime StartDate { get; set; }

        public int LocationId { get; set; }

        public MarketLocation location { get; set; }

 
    }
}
