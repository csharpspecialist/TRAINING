using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingReferenceStrings2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girl....what is your maiden name??");
            string mName = Console.ReadLine();

            NameChange(mName);
            Console.WriteLine($"in the main method...my maiden name  is {mName}");

            NameTransform(ref mName);
            Console.WriteLine($"Inside of the very very main method the value of player 1 is {mName}");

            Console.ReadLine();
        }

        public static void NameChange(string mName)
        {
             mName= "Mann";
            Console.WriteLine($"Inside of the Name change method, the name of Player 1 \n is {mName}");

        }

        public static void NameTransform(ref string mName)
        {
            mName = "Tiller";
            Console.WriteLine($"today {mName}");

        }



    }
}
