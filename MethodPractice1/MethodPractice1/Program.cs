using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Restaurants r = new Restaurants();

            Fashion f = new Fashion();




            Console.WriteLine("This is the main method landing page");


            r.Chipotle();
            f.Pants();



            Console.ReadLine();

        }
        
        public  void Addition()
        {

        }


       public  void Mulitplication()
        {


        }

        public  void Division()
        {

        }



    }


    class Fashion
    {
        
        public void Shirts()
        {
            Console.WriteLine("Button downs");

            Console.WriteLine("V - Necks");

            Console.WriteLine("Henley's");


        }

        public void Pants()
        {



        }

        public void Shoes()
        {



        }






    }



}
