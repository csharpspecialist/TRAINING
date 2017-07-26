using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("Using 2 arguments here!!!");
            DisplaySize(10, 20);
            Console.WriteLine("Using 3 arguments now");
            DisplaySize(1, 2, 3);
            ReadLine();


        }

        public static void DisplaySize(int length, int width, int height =1)
        {
            int area = length * width * height;
            Console.WriteLine($"the length {length} * the width {width} * the optional height of {height} equals {area}");
            ReadLine();

        }



    }
}
