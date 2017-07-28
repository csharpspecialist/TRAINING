using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValuePracticeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 200;
            int number2 = 300;

           int complete =  TotalNumber(number1,number2);

            Console.WriteLine(complete);
           
            Console.ReadLine();

        }

        private static int TotalNumber(int n1, int n2)
        {
            int product = n1 * n2;

            return product;


        }


    }
}
