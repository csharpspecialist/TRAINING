using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice1
{
    class Restaurants
    {

        public static void FamousDaves()
        {
            Fashion fash = new Fashion();
            Program p = new Program();
            Restaurants r = new Restaurants();

            fash.Pants();
            fash.Shirts();
            r.Chipotle();
           


        }

        public void Chipotle()
        {

            Console.WriteLine("We make burritos");
        }

        public void Benihana()
        {
            Console.WriteLine("We cook the food right in front of you");
        }



    }
}
