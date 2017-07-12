using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color");
            string color = Console.ReadLine();


            switch(color)
            {

                case "red":
                    Console.WriteLine("Red is an ok Color");
                    break;

                default:
                    Console.WriteLine("We don't understand your answer");
                    break;
                    
            }

            Console.ReadLine();
        }
    }
}
