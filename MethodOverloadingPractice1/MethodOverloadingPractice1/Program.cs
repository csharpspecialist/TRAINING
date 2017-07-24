using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingPractice1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int firstRealNumber, secondRealNumber;
            double firstDouble;

            Console.WriteLine("Give me a number to work with");
            string firstNum = Console.ReadLine();

            Console.WriteLine("Give me a second number to work with");
            string secondNum = Console.ReadLine();



            Console.WriteLine("Give me a double to work with");
            string secondDouble = Console.ReadLine();

            int.TryParse(firstNum, out firstRealNumber);
            int.TryParse(secondNum, out secondRealNumber);
            double.TryParse(secondDouble, out firstDouble);


            MultiplyIntegers();


            MultiplyIntegers(firstRealNumber);
            MultiplyIntegers();

            MultiplyIntegers();



            MultiplyIntegers(firstRealNumber, secondRealNumber);

        }


        public static void MultiplyIntegers()
        {
            int number1 = 0 ;
            Console.WriteLine($"The first realnumber is here {number1} with no integers");
            Console.ReadLine();


        }

        public static void MultiplyIntegers(int number1)
        {
            int number2;
            Console.WriteLine($"The first realnumber {number1} is here with 1 integer");
            Console.ReadLine();

        }
        
        public static void MultiplyIntegers(int val1, int val2)
        {
            
            Console.WriteLine("The first realnumber is here with 2 integers");
            int product = val1 * val2;

            Console.WriteLine($"The product of {val1} and {val2} is {product}");

            Console.ReadLine();
        }

        public static void MultiplyIntegers(double valDouble)
        {

            Console.WriteLine($"The first double value is {valDouble}");
            Console.ReadLine();

        }

        public static void MultiplyIntegers(double valDouble, double valDouble2)
        {

            Console.WriteLine($"The first double value is {valDouble}");
            Console.ReadLine();

        }

    }
}
