using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCModelFirstFreehand.Models
{
    public class Cars
    { 

        public int ID { get; set; }

        [Display(Name = "Model Year")]
      
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }

    }

    public class CarsDbContext : DbContext
    {
        public DbSet<Cars> Autos { get; set; }

    }

}
