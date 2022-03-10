using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Models.DTOs
{
    public class MailDto
    {
        public string Recipient { get; set; }

        public string Title { get; set; }

        public string Message { get; set; }
    }
}
