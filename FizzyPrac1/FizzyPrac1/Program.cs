using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzyPrac1
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            p.FizzOn();
            Console.ReadLine();

            for (int i = 0; i < 101; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine($"The number is " + i);
                }
            }

            Console.ReadLine();

        }


        public void FizzOn()
        {
            int i;


            for (i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)

                {
                    Console.WriteLine("Fizz Buzz");
                }

                else if (i % 3 == 0)

                {
                    Console.WriteLine("Fizz");
                }

                else if (i % 5 == 0)

                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }

      

    }

    


   

}
