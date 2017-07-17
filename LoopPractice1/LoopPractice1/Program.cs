using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            //i < 10;
            //i++;

            //arrays
            // array of fixed size.
            //arrays sizes cannot be changed once created 
            // arrays are 0 based

            int [] numbers = { 2,4,88,11,55,99,165};
            string[] stars = { "Beyonce", "Rianna", "Janet Jackson", "Madonna" };

            for ( i = 0; i < 3; ++i)
            {
                Console.WriteLine($"The value of i is {i}");
               // Console.WriteLine("The value of i is {0}", i);
            }
            Console.ReadLine();


            for (int k = 0; k < 4; ++k)
            {
                Console.WriteLine("The stars are " + (stars[k]));

            }
            Console.ReadLine();

            for (int f = 0; f < numbers.Length; ++f)
            {
                Console.WriteLine("The stars are " + (numbers[f]));

            }
            Console.ReadLine();

            for (int d = 0;d < numbers.Length; ++d )
            {
                Array.Reverse(numbers);
                Console.WriteLine(numbers[d]);
                
            }
            Console.ReadLine();


        }
    }
}
