using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePracticeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt16(number1);

            Console.WriteLine("Give me a second number");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);

            if(num1 < num2)
            {
                Console.WriteLine($"Number {number1} is less than {num2}");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"Your first Number {num1} is greater than your second number {num2} ");
            }
            else
            {
                Console.WriteLine($"Your first number {num1} is equal to your second number of {num2}" );
            }

            Console.ReadLine();
        }
    }
}
