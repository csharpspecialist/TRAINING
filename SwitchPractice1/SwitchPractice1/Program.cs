using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SwitchPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color");
            string color = Console.ReadLine().ToLower();


            switch(color)
            {

                case "red":
                    Console.WriteLine("Red is an ok Color");
                    break;

                case "blue":
                    Console.WriteLine("Blue is nice");
                break;

                case "pink":
                    Console.WriteLine("Everyone loves pink");
                    break;     
                    

                default:
                    Console.WriteLine("We don't understand your answer");
                    break;
                    
            }
            Console.Write("We broke out of the loop");
            Console.ReadLine();




            bool yes;
            int foodLike;
            Console.WriteLine("What's is your favorite pasta dish \n 1. Lasagne \n 2. Spaghetti \n 3. Ravioli");
            //int foodChoice = Convert.ToInt32(ReadLine().ToUpper());
            string foodChoice = Console.ReadLine();
            //int foodChoice = int.Parse(ReadLine());
           int.TryParse(foodChoice, out foodLike);
           // double food = Convert.ToDouble(ReadLine().ToUpper());

            switch(foodLike)
            {
                case 1:
                    Console.WriteLine("Lasagne is fantastic!!!");
                    break;

                case 2:
                    Console.WriteLine("Spaghetti is delicious");
                    break;

                case 3:
                    Console.WriteLine("Ravioli was invented by Chev Boyardi!!!");
                    break;

                default:
                    Console.WriteLine("That's not a pasta choice we recognize");
                    break;



            }
            Console.WriteLine("We broke out of the switch statement!!");
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
