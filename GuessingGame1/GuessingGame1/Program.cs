using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Random rand = new Random();

            int rNum = rand.Next(1, 6);
            int realNum;

            Console.WriteLine("Enter a number between 1 and 5");
            string numGuess = Console.ReadLine();

            int.TryParse(numGuess, out realNum);

            //while (realNum < 0 || realNum > 6)
            //{
            //    Console.WriteLine("You must guess between 1 and 5...try again");
            //    numGuess = Console.ReadLine();
            //    int.TryParse(numGuess, out realNum);
            //}

            while (realNum !=rNum)
            {
                Console.WriteLine($"Your guess of {numGuess} was not the correct #...\n Guess again");


                numGuess = Console.ReadLine();
                int.TryParse(numGuess, out realNum);

            }

            Console.WriteLine($"Your guess of {rNum} was correct...Hooray");
            Console.ReadLine();




        }
    }
}
