using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name??");
            string userName = Console.ReadLine();
            //string concatenation
            Console.WriteLine("Hello " + userName + " How r u today");

            Console.ReadLine();

            Console.WriteLine("What is your age??");
            string age = Console.ReadLine();

            Console.WriteLine("you are and {0} old guy", age);
            //variable dropping into place
            Console.WriteLine(" {0} you are an {1} year old guy am I right {2}",userName, age,age);
            Console.ReadLine();

            Console.WriteLine("R U going out tonight:");
            string goingOut = Console.ReadLine();


            //  string interpolation 
            Console.WriteLine($"My name is {userName} I am {age} and {goingOut} of course");
            Console.ReadLine();





        }
    }
}
