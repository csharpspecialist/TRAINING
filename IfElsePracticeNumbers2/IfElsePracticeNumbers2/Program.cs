using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePracticeNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a first number");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number");
            int number2 = int.Parse(Console.ReadLine());

            if(number1 > number2)
            {
                Console.WriteLine($"Your number {number1} is greater than your number of {number2}");
            }
            else if( number1 < number2)
            {
                Console.WriteLine($"Your number of {number1} is less than your number of {number2}");
            }
            else
            {
                Console.WriteLine($"Your number of {number1} is equal to your number of {number2}");
            }
            Console.ReadLine();


        }
    }
}
