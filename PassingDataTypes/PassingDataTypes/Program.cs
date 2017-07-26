using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayInt = { 1, 5, 12, 66, 27 };
            string[] nameArray = { "Nancy Drew", "Columbo","Hardy Boys" };

            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.WriteLine("The value of the Arrayint array is " + arrayInt[i]);
            }

            Console.WriteLine("we r now out of th loop");
            Console.ReadLine();

            MaxArray(arrayInt);
            SumArray(arrayInt);
            ListNames(nameArray);
        }


        public static void SumArray(int [] arrayVals)
        {
            int sumation = arrayVals.Sum();
            Console.WriteLine($"the sum of the array is {sumation}");
            Console.ReadLine();     
            
        }

        public static void MaxArray(int [] intArray)
        {
            int maxVal = intArray.Max();
            Console.WriteLine($"The maximum value of the array is {maxVal} ");
            Console.ReadLine();

        }

        public static void ListNames(string [] Names)
        {
            for(int k = 0; k < Names.Length; k++  )
            {
                Console.WriteLine("The names of the ArrayNames array are " + Names[k]);
            }
            Console.ReadLine();
        }



    }
}
