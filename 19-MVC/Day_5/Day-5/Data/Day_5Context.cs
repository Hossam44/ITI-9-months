﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day_5.Data
{
    public class Day_5Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Day_5Context() : base("name=Day_5Context")
        {
        }

        public System.Data.Entity.DbSet<Day_5.Models.Coustomer> Coustomers { get; set; }

        public System.Data.Entity.DbSet<Day_5.Models.Order> Orders { get; set; }
    }
}
