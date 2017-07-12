using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePracticeNumbers3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age");
            double firstNum = double.Parse(Console.ReadLine());

            if(firstNum > 1 && firstNum <= 10)
            {
                Console.WriteLine("You r just a kid");
            }
            else if (firstNum >= 11 && firstNum <= 20)
            {
                Console.WriteLine("You are in your middle years");
            }
            else if (firstNum >= 21 && firstNum <= 35)
            {
                Console.WriteLine("You r getting there");
            }
            else if (firstNum >= 36 && firstNum <= 55)
            {
                Console.WriteLine("You have it figured out by now");
            }
            else
            {
                Console.WriteLine("You r in your golden years!!!");
            }

            Console.ReadLine();
            Console.WriteLine($"here is ${firstNum}");
            Console.ReadLine();
        }
    }
}
