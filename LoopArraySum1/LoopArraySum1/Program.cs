using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArraySum1
{
    class Program
    {
        static void Main(string[] args)
        {

            int total = 0;

            //total = 110
            int[] nums = { 5, 10, 15, 20, 10, 50 };

            for (int q = 0; q < nums.Length; ++q)
            {
                Console.WriteLine($"The value of q currently is {(nums[q])}");
                total  += nums[q];

            }
            Console.WriteLine($"The total value of the nums array is {total}");
            Console.ReadLine();
        }
    }
}
