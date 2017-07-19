using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int randNum = r.Next(1, 11);
            int actualNum;
            int numOfGuesses = 1;

            Console.WriteLine("Guess a number between 1 and 10");            

            do
            {
                string numGuess = Console.ReadLine();
                while (!int.TryParse(numGuess, out actualNum) || actualNum < 1 || actualNum > 10)
                {

                    Console.WriteLine($"You entry of {numGuess} is crazy \n Try again");
                    numGuess = Console.ReadLine();
                    //int.TryParse(numGuess, out actualNum);

                    numOfGuesses++;

                }

                if (randNum == actualNum)
                {
                    Console.WriteLine($"Your guess of {randNum} was correct \n You guessed {numOfGuesses} times...You are a winner!!!");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine($"Your guess of {actualNum} was not correct...\n Guess again");
                    numOfGuesses++;
                }

                //Console.ReadLine();


            } while (actualNum != randNum);

        }
          

    }
}
