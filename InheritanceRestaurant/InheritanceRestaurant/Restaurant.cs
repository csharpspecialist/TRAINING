using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRestaurant
{
    //Base Class
    public class Restaurant
    {
        public string Sauce;
        public string Pork1;
        public string Pork2;
        public string Veg1;
        public string Veg2;


        public virtual void PrintToppings()
        {
            Console.WriteLine($"Your pizza has {Sauce} + {Pork1} and {Veg1}");

        }

    }
}
