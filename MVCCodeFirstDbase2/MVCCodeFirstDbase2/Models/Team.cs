using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCCodeFirstDbase2.Models
{
    public class Team
    { 
        public int TeamID { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string City { get; set; }
        public int NetWorth { get; set; }
       
        

    }

    public class TeamDBContext : DbContext
    {
        public DbSet<Team> Tough { get; set; }
    }


}