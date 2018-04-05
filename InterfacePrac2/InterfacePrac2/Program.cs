using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePrac2
{
    interface ISpace
    {
       void Print();
    }


    class Program 
    {
        static void Main(string[] args)
        {

            Starter st = new Starter();
            st.Print();

            int realVal;
             Console.WriteLine("Pick a # between 1 and 100");
            string ice = Console.ReadLine();
            int.TryParse(ice, out realVal );

            while (realVal < 1 || realVal > 100)
            {
                Console.WriteLine("We don't understand your answer");
                Console.WriteLine("Pick a # between 1 and 100");
                ice = Console.ReadLine();
                int.TryParse(ice, out realVal);

            }
            Console.WriteLine("We r done");
            Console.ReadLine();

        }

  
    }


    class Starter : ISpace
    {
        public void Print()
        {
            Console.WriteLine("This is Saturday");
        }
    }

}
