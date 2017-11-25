using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Web;

namespace MVCElite1.Data
{
    public class Company
    {
        public int ID { get; set; }

        public string SelectedList { get; set; }
        public List<Customer> People
        {
            get
            {
                SKYFALLEntities db =new SKYFALLEntities();
                return db.Customers.ToList();
            }
        }

    }


}