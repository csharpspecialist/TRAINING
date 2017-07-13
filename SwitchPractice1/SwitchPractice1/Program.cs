using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color");
            string color = Console.ReadLine();


            switch(color)
            {

                case "red":
                    Console.WriteLine("Red is an ok Color");
                    break;
                    //unreachable code demo

                default:
                    Console.WriteLine("We don't understand your answer");
                    break;
                    
            }

            Console.ReadLine();
        }


        public static void Parsing()
        {
            
            int realVisit;
            Console.WriteLine("How many times have you seen the doctor this year");
            //int docVist = Convert.ToInt32(Console.ReadLine());  //can blow up
            int dVisit = int.Parse(Console.ReadLine());  //can blow up also
            string doctorV = Console.ReadLine();
            int.TryParse(doctorV, out realVisit);  //exits program w/o blowing up!!

            switch (realVisit)
            {
                case 3:
                    Console.WriteLine("Work is being done here!!!!");
                    break;

            }


        }






    }
}
