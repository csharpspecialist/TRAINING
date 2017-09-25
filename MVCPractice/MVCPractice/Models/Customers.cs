using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCPractice.Models
{
    public class Customers
    {

        public int ID { get; set; }
        [ Display(Name = "Last Name") ]
        public string LastName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

    }

    public class CustomerDBContext: DbContext
    {

        public DbSet<Customers> Cust { get; set; }
    }

}