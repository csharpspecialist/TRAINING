using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCAddColumnToDbase.Models
{
    public class Motorcycle
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        [Display(Name = "Bike Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Style { get; set; }
        public int CC { get; set; }
        public decimal Price { get; set; }
    }

        public class MotorcycleDBContext : DbContext
        {
            public DbSet<Motorcycle> Bikes { get; set; }
        }


    }