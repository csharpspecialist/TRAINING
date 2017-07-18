using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            // Random rnd = new Random();
            Vacation v = new Vacation();
            Console.WriteLine("Hello world");

            p.Working();
           Talking();

            v.Bahamas();
            v.Cancun();
            v.Nice();
            Console.WriteLine("I'm Baaaack in the main method!!!!");
            Console.ReadKey();
        }

        public void Working()
        {
            Console.WriteLine("Hey...I'm workin over here!!!!");            

        }

        public static void Talking()
        {
            Console.WriteLine("Talking a lot today");
        }


    }
}
