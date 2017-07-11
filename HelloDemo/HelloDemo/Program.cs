using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloDemo
{
    class Program
    {

        int smog = 5;
        static void Main()
        {
             
            Console.WriteLine("Hello World");
            //Console.ReadKey();

           // Console.WriteLine("W r here to become developers");
            
            Console.WriteLine("today is Friday");
            Console.WriteLine("today is Friday");

            Console.ReadKey();
            WriteLine("We will go to lunch soon!!!");
            Write("now \n");
            Write("today");
            ReadKey();




            //int 5a = 10;
            //  5 int = x;
            int x = 5,  d =6;
            int b = 10;

            Worker();
            Nice(); //no instance here to call this method
            Gamer();
            Complete();

            
            
        }

        public void Gamer()
        {
            Console.WriteLine($"we don't like {smog}");
        }



        public static void Nice()
        {  // have to create an instance for this to work
            Program p = new Program();

            Console.WriteLine($"we don't like {p.smog}");


        }

        public static void Worker()
        {


        }

        public int Complete()
        {

            int nice = 4;
            return nice;


        }

        
    }
}
