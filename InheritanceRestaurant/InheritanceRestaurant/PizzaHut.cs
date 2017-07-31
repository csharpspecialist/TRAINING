using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRestaurant
{
    public class PizzaHut : Restaurant
    {

        public string Bread1;
        public string Meat1;
        public string Chicken; 
           
        public override void PrintToppings()
        {
            //base.PrintToppings();
            Console.WriteLine($"Your Pizza Hut Pizza has {Sauce} & {Meat1} plus {Bread1}");
            
        }
             



    }
}
