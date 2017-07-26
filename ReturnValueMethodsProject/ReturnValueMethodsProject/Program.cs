using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValueMethodsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //first we see the ref method being demonstrated
            int x = 5;
            Console.WriteLine($"The initial value of x is {x}");
            ReturnRefMethod(ref x);
            Console.WriteLine($"The new value of x in the Main method is {x}");
            Console.ReadLine();

            int score = ReturnValMethod(x); //notice we have to store the result inside of a
            Console.WriteLine($"The value of x is now {x} inside the main method \n after returning from the Return Value method");
            Console.ReadLine();
        }

        public static void ReturnRefMethod(ref int x)
        {
           
            Console.WriteLine($"The initial value of x inside the Ret Ref Method is {x}");
            x = 20;
            Console.WriteLine($"The new Changed value of x in the Return Ref Method is {x}");


        }
        //this method has a return type of int...new, new, new!!!!
        public static int ReturnValMethod(int x)
        {
            Console.WriteLine($"The initial value of x inside the Ret Value Method is {x}");
            int y = 50;
            x += y;
            Console.WriteLine($"We added {y} to {x} & now the Changed value of x in the Return Ref Method is {x}");
            return x;
        }



    }
}
