using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Models.ViewModels
{
    public class CreateMarketViewModel
    {
        [Required]
        [Display(Name = "Market Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "How often does the market hold?")]
        public int Frequency { get; set; }
        [Required]
        [Display(Name = "Select the next market Day")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name ="Location")]

        public int LocationId { get; set; }
 /*       public string SelectedLocationId { get; set; }
        public IEnumerable<SelectListItem> Locations { get; set; }*/
    }
}
