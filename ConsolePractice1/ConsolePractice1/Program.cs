using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("what is your name");
            //string dude = Console.ReadLine();

            //Console.WriteLine($"My name is {dude} ");
            //Console.ReadKey();

            Console.WriteLine("What's you age");
            string ageNumber = Console.ReadLine();

            Console.WriteLine("What's your street name");
            string streetName = Console.ReadLine();

            Console.WriteLine("What's your email address");
            string email = Console.ReadLine();


            Console.WriteLine($" My age is {ageNumber}, my street name is {streetName}, my email address is {email}   ");

            Console.ReadKey();



               



        }
    }
}
