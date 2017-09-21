using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCCinema.Models
{
    public class EmployeeContext : DbContext
    {

        public DbSet<Region> Regions { get; set; }

    }
}