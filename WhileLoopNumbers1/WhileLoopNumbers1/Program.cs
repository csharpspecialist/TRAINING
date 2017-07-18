using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idNum;
            int lowNum = 1000;
            int highNum = 2000;

            Console.WriteLine("Enter a valid Id Number");
            string valNum = Console.ReadLine();
            int.TryParse(valNum, out idNum);

            while(idNum < lowNum || idNum > highNum)
            {
                Console.WriteLine($"The ID number you entered {valNum} \n " 
                    + $"must be between {lowNum} and {highNum} \n Try again");

                valNum = Console.ReadLine();
                int.TryParse(valNum, out idNum);
            }

            Console.WriteLine("The id number that you entered was valid!!");
            Console.ReadKey();
        }
    }
}
