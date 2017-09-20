﻿using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCFreehandDbaseConnect.Models
{
    public class Cars
    {

        public int ID { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }



    }

    public class CarsDBContext: DbContext
    {
        public DbSet<Cars> Car { get; set; }
    }

}