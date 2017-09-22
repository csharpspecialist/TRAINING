﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCTest2.Models
{
    public class Auto
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        
    }

    public class AutoDBContext : DbContext
    {
        public DbSet<Auto> Autos { get; set; }
    }



}