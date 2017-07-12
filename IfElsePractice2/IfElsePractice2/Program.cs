using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePractice2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorite car");
            string favorite = Console.ReadLine().ToLower();

            if(favorite == "chevy")
            {
                Console.WriteLine("I like chevies also!!! ");
            }
            else if (favorite == "dodge")
            {
                Console.WriteLine("Dodge vehicles are OK also");
            }
            else if (favorite == "Infiniti")
            {
                Console.WriteLine("Those are NICE!!!");
            }
            else
            {
                Console.WriteLine("We don't understand that car choice");
            }
            Console.ReadLine();



        }
    }
}
