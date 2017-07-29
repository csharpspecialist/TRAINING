using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValueClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string rest = "Chipotle";
            string favFood = "Burritos";

            double years = 20;
            double days = 365;

            string full = FavRestaurant(rest, favFood);

            Console.WriteLine(full);

            double completeAge = Youngster(years, days);

            Console.WriteLine(completeAge);

            Console.ReadLine();

        }
        
        private static string FavRestaurant(string eatery, string goodies)
        {
            string bestMeal = eatery + " " + goodies;

            return bestMeal;
        }


        private static double Youngster(double yearAge, double dayAge)
        {

            double totalAge = yearAge * dayAge;

            return totalAge;

        }




    }
}
