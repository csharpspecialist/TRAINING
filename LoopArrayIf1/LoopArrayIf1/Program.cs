using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArrayIf1
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            int[] pieces = {11,77,66, 33, 51, 22, 78, 90 };

            for ( d =0; d < pieces.Length; ++d   )
            {
               
                if (pieces[d] == 51)
                {                   
                    Console.WriteLine("We found 51");
                    break;
                }
                Console.WriteLine($"The value of the pieces array is currently {(pieces[d])} ");
                Console.ReadLine();
            }
            Console.WriteLine("The loop is over!!!!");
            Console.ReadLine();

            string[] cars = { "Buick", "Datsun", "BMW", "Chevy", "Corvette", "Olds" };

            for (int e = 0; e < cars.Length; ++e)
            {
                Console.WriteLine($"The value of the cars array is currently {(cars[e])} ");

                if (cars[e] == "Corvette")
                {
                    Console.WriteLine("We found the Vette ");
                    break;
                }

            }
            Console.WriteLine("We were kicked out of the loop!!!!");
            Console.ReadLine();

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();

            foreach(int piece in pieces)
            {
                Console.WriteLine($"These are the values of the pieces array {piece}");
            }
            Console.ReadLine();

        }
    }
}
