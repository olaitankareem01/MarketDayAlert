﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketDayAlertApp.Entities
{
    public class Role
    {
            public int Id { get; set; }
            public string Name { get; set; }

            public string Description { get; set; }

            public IList<User> Users { get; set; }
        
    }
}
