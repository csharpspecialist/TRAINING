using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingReference1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"In the main method x = {x}");
            DisplayValueParameter(x);
            Console.WriteLine($"In the main method the value of x is now {x}");
            DisplayNewValue(ref x);

            Console.WriteLine($"the value of exiting x is now {x}");

            DisplaySecondValue(ref x);
            Console.WriteLine($"The value of z is now {x}");

            Console.ReadLine();

        }
        #region Normal


        private static void DisplayValueParameter(int x)
        {

            x = 1000;
            Console.WriteLine($"We r in the Display Value Parameter Method \n Where x = {x}");            
        }
        


        private static void DisplayNewValue(ref int n)
        {
            n = 1000;
            Console.WriteLine($"We r in the very exiting new value Method \n Where x = {n}");

        }


        private static void DisplaySecondValue(ref int z)
        {
            z = 555;
            Console.WriteLine($"We r in the very exiting new value Method \n Where x = {z}");
            
        }


        #endregion

    }
}
