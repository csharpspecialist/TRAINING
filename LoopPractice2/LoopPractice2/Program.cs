using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice2
{
    class Program
    {
        static void Main(string[] args)
        {

            // string[] colors = {"Red", "Blue", "Green", "Black", "White" };

            // for (int i = 2; i < colors.Length; ++i )
            // {
            //     Console.WriteLine("Here are the colors of the colors array" + (colors[i]));
            // }
            // Console.ReadLine();

            // int[] nums = new int [4];
            // nums[0] = 10;
            // nums[1] = 20;
            // nums[2] = 30;
            // nums[3] = 40;

            // for (int n = 0; n < nums.Length; ++n)
            // {
            //    // Console.WriteLine("The values of array nums is" + (nums[n]));
            //     Console.WriteLine($"The values of array nums is {(nums[n])}");
            // }
            // Console.ReadLine();

            // char[] letters = new char [] { 'v','i','n','c','e' };
            //for(int m=0; m < letters.Length; ++m)
            // {
            //     Console.WriteLine($"The value of the letters array are {(letters[m])}");

            // }
            // Console.ReadKey();

            // for (int m = 0; m < letters.Length; ++m)
            // {
            //     Console.Write( (letters[m]));
            // }
            // Console.ReadKey();

            string[] row = { "Bill", "Mike", "Goliath", "Bruce", "Peter", };
            string[] col = { "Merry", "Cammy", "Gemma", "Carla", "Jean", };
            int rows = 5;
            int cols = 3;


            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    Console.WriteLine("Row : " + i + " Column :" + k  );
                  //  Console.WriteLine("col : " + i);
                }
            }
            Console.WriteLine($" \n The # of rows total is {row} and the # of Columns total is {col}");

            Console.ReadLine();

            for (int i = 0; i < row.Length; i++)
            {
                for (int k = 0; k < col.Length; k++)
                {
                    Console.WriteLine((row[i]));
                    //  Console.WriteLine("col : " + i);
                }
            }
            Console.WriteLine($" \n The # of rows total is {row} and the # of Columns total is {col}");

            Console.ReadLine();
        }
    }




}
