using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCFreehandDbaseConnect.Models
{
    public class Games
    {


        public int ID { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        
        public string Genre { get; set; }
        public double Price { get; set; }



    }

    public class GamesDBContext : DbContext
    {
        public DbSet<Games> Fun { get; set; }
    }



}
