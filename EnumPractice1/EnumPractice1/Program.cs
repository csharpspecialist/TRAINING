using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice1
{

    enum Movies
    {
        Jaws = 1,
        Goodfellas,
        Heat,
        Scarface,
        Godfather,
        Avatar,
        Inception,
        GetOut

    }

  


    class Program
    {
        static void Main(string[] args)
        {

            int favMovie;
            Console.WriteLine("Which Movie is your favorite \n 1. Jaws \n 2. Goodfellas \n 3. Heat");
            string favorite = Console.ReadLine();

            int.TryParse(favorite, out favMovie);
         
            switch ((Movies)favMovie)
            {
                case Movies.Jaws:
                    Console.WriteLine("Jaws was a great movie");
                    break;
                case Movies.Goodfellas:
                    Console.WriteLine("Goodfellas..an American Classic");
                    break;
                case Movies.Heat:
                    Console.WriteLine("Heat.. A Thriller in Miami");
                    break;
                default:
                    Console.WriteLine("That movie did not make our list");
                    break;
                }

            Console.WriteLine("Out of the movie switch statement block");
            Console.ReadKey();

            

        }
    }

    enum Cars
    {


    }

}
