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
        // global scope
        string blue = "COLOR BLUE";


        static void Main()
        {
            Program np = new Program();
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

            //local variables 
            // local scope

            //int 5a = 10;
            //  5 int = x;
            int x = 5,  d =6;
            int b = 10;
            int e;
           string blaxe;
            string cry = "";
            //Dream();
            //NewMethod();
            //np.Multiply();
            NewProgram newp = new NewProgram();
            newp.Casing();

            
        }


        public static void NewMethod()
        {
            Program p = new Program();
          string now = "Please";
            Console.WriteLine("We r now in the New method");
            //string now = "clear";
            Console.WriteLine("Hello CC4");
            Console.WriteLine(p.blue);
            Console.ReadLine();
            WriteLine($"{now} stop asking {now}");

            WriteLine($"{now} stop asking now {now}");
            
        }

        static void Dream()
        {
            string now = "Please";
            Console.WriteLine("We r now in the Dream method");
            Console.WriteLine("New things are being taught now today!!!!");
            WriteLine($"{now} stop asking {now}");
        }


        public void Multiply()
        {
            Console.WriteLine("We r now in the Multiply method");
            Console.WriteLine("Class is fun!!!!");
            ReadLine();
        }
        
        
    }

    class NewProgram
    {
        
        public void Casing()
        {
            int realVisit;
            Console.WriteLine("How many times have you seen the doctor this year");
            //int docVist = Convert.ToInt32(Console.ReadLine());  //can blow up
            int dVisit = int.Parse(Console.ReadLine());  //can blow up also
            string doctorV = Console.ReadLine();
            int.TryParse(doctorV, out realVisit);  //exits program w/o blowing up!!

            //switch(realVisit)
            //{
            //    case 3:
            //        Console.WriteLine("Work is being done here!!!!");
            //        break;

            //}
        }




    }


}
