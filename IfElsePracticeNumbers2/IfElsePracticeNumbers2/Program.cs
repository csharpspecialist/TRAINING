using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

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

            if (number1 > number2)
            {
                Console.WriteLine($"Your number {number1} is greater than your number of {number2}");
            }
            else if (number1 < number2)
            {
                Console.WriteLine($"Your number of {number1} is less than your number of {number2}");
            }
            else
            {
                Console.WriteLine($"Your number of {number1} is equal to your number of {number2}");
            }
            ReadLine();

            WriteLine("Enter a number:");
            string food = Console.ReadLine();
        }

        public static void Parsing()
        {

            int realVisit;
            Console.WriteLine("How many times have you seen the doctor this year");
            //int docVist = Convert.ToInt32(Console.ReadLine());  //can blow up
            int dVisit = int.Parse(Console.ReadLine());  //can blow up also
            string doctorV = Console.ReadLine();
            int.TryParse(doctorV, out realVisit);  //exits program w/o blowing up!!

            switch (realVisit)
            {
                case 3:
                    Console.WriteLine("Work is being done here!!!!");
                    break;

            }

            double var1 = Convert.ToDouble(ReadLine());
            WriteLine("Enter another number:");
            double var2 = Convert.ToDouble(ReadLine());
            WriteLine("Enter a 3rd number");
            decimal dec3 = Convert.ToDecimal(ReadLine());

        }
    }
}
