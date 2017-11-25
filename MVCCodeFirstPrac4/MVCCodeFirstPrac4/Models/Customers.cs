using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCCodeFirstPrac4.Models
{
    public class Customers
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }


    }

    public class CustomersDBContext: DbContext
    {

        public DbSet<Customers> People { get; set; }

    }



}