using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Calculator
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            Console.WriteLine("hello we are at the beginning of then main method");
            RunAgain();


            Console.WriteLine("now we are at the end of main method");
            Console.ReadLine();
        }


        public static void RunAgain()
        {
            Console.WriteLine("in the run again method now!!!!");
            Main();
        }






    }
}
