using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers1
{
    public class Program
    {
       public static void Main()
        {
            Movies title = new Movies();
            
            int number1 = 200;
            int number2 = 300;

            int complete = TotalNumber(number1, number2);

            Console.WriteLine(complete);

            Console.ReadLine();

            int answer = PlusNumber(number1, number2);

            Console.WriteLine(answer);

            Console.ReadLine();


            double divide = DivideNumber(number1, number2);

            Console.WriteLine(divide);

            Console.ReadLine();

        }

        private static int TotalNumber(int n1, int n2)
        {
            int product = n1 * n2;

            return product;


        }

        private static int PlusNumber(int n1,int n2)
        {
            int sum = n1 + n2;
            return sum;

        }

        public static double DivideNumber(int n1, int n2)
        {
            double divNumber = n1 / n2;

            return divNumber;


        }



    }
}
