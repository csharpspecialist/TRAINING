using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            PapaJohns pa = new PapaJohns();

            pa.Sauce = "Tomato";
            pa.Pork1 = "Italian Sausage";
            pa.Veg1 = "Mushrooms";
            
            pa.PrintToppings();
            

            Console.WriteLine("***********");


            PizzaHut ph = new PizzaHut();
            ph.Sauce = "Marinara";
            ph.Bread1 = "Stuffed Crust";
            ph.Meat1 = "Ground Beef";
            ph.PrintToppings();

            Console.WriteLine("***********************");




            Console.ReadLine();

           

        }
    }




}
