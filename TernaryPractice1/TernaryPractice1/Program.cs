using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your favorite sport");
            //string sport = Console.ReadLine().ToLower();
            //string favSport = (sport == "hockey" || sport == "football" || sport == "golf") ? "Great Choice" : "Bad Choice";
            //Console.WriteLine(favSport);
            //Console.ReadLine();


            Console.WriteLine("Name the first food do you like");
            string food = Console.ReadLine().ToLower();
            Console.WriteLine("Name a second food that you like");
            string food2 = Console.ReadLine().ToLower();
           Console.WriteLine("Name a 3rd outer space kid food");
            string food3 = Console.ReadLine().ToLower();

            string foodChoice = (food == "chicken" && food2 == "shrimp" && food3 == "meat") ? "Good Choice" : "Bad Choice";
            Console.WriteLine(foodChoice);
            Console.WriteLine($"Your first choice was {food}, your second choice was {food2} and your third choice was {food3}");
            Console.ReadLine();








            
        }
    }
}
